using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameStore
{
    public partial class CartedItem : Form
    {
        private string connectionString;
        private int userId;
        public CartedItem(string connectionString, int userId)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userId = userId;
            this.cart_grid.AutoGenerateColumns = false;
            LoadData();
        }

        //
        // function to load data in cart_grid
        //
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT c.cartId, c.gameId, g.gametitle, c.quantity, c.dateAdded 
                                 FROM GameStore.dbo.Cart c
                                 INNER JOIN GameStore.dbo.games g ON c.gameId = g.gameid
                                 WHERE c.userId = @userid";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@userid", userId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.cart_grid.DataSource = dt;
            }
        }

        //
        // Event to remove item from cart
        //
        private void remove_from_cart_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in cart_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                    {
                        string query = "Delete from GameStore.dbo.Cart where cartId = @cartId and gameId = @gameId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@cartId", row.Cells["cartId"].Value);
                        cmd.Parameters.AddWithValue("@gameId", row.Cells["gameId"].Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Refresh the cart grid
            LoadData();

            MessageBox.Show("Item removed from cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // function to find address of the user
        //
        private string findAddress()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT shippingAddress FROM GameStore.dbo.Users WHERE userId = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                string address = (string)cmd.ExecuteScalar();
                return address;
            }
        }

        //
        // function to find total amount of order
        //
        private decimal findPrice(SqlConnection con, int gameId)
        {
            string query = @"select price from GameStore.dbo.games where gameid = @gameId";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@gameId", gameId);
                object result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }


        //
        // Event to place order
        // 
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // inserting data into Order table 
                con.Open();
                string query = @"Insert into GameStore.dbo.Orders (userId, trackingNumber, shippingAddress, totalAmount, status) 
                                            values (@userId, @track_number, @address, @amount, @status);
                                            SELECT SCOPE_IDENTITY();";
                int trackingNumber = new Random().Next(100000, 999999);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@track_number", trackingNumber);
                cmd.Parameters.AddWithValue("@address", findAddress());
                decimal sum = 0;
                foreach (DataGridViewRow row in cart_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                    {
                        decimal price = findPrice(con, (int)row.Cells["gameId"].Value);
                        int quantity = (int)row.Cells["quantity"].Value;
                        price *= quantity;
                        sum += price;
                    }
                }
                cmd.Parameters.AddWithValue("@amount", sum);
                cmd.Parameters.AddWithValue("@status", "pending");
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert order details into OrderDetails table
                foreach (DataGridViewRow row in cart_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                    {
                        int gameId = (int)row.Cells["gameId"].Value;
                        int quantity = (int)row.Cells["quantity"].Value;
                        decimal pricePerUnit = findPrice(con, gameId);

                        string orderDetailsQuery = @"INSERT INTO GameStore.dbo.OrderDetails (orderId, gameId, quantity, pricePerUnit) 
                                     VALUES (@orderId, @gameId, @quantity, @pricePerUnit)";
                        using (SqlCommand detailCmd = new SqlCommand(orderDetailsQuery, con))
                        {
                            detailCmd.Parameters.AddWithValue("@orderId", orderId);
                            detailCmd.Parameters.AddWithValue("@gameId", gameId);
                            detailCmd.Parameters.AddWithValue("@quantity", quantity);
                            detailCmd.Parameters.AddWithValue("@pricePerUnit", pricePerUnit);
                            detailCmd.ExecuteNonQuery();
                        }

                        string updateCart = @"delete from GameStore.dbo.Cart where userId = @userId and gameId = @gameId";

                        using (SqlCommand deleteCmd = new SqlCommand(updateCart, con))
                        {
                            deleteCmd.Parameters.AddWithValue("@gameId", row.Cells["gameId"].Value);
                            deleteCmd.Parameters.AddWithValue("@userId", this.userId);
                            deleteCmd.ExecuteNonQuery();
                        }

                    }
                }

                MessageBox.Show("Order Successfully Placed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
