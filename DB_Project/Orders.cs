using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Orders : Form
    {
        private string connectionString;
        private int userId;
        public Orders(string connectionString, int userId)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userId = userId;
            this.order_grid.AutoGenerateColumns = false;
            LoadData();
        }

        //
        // Function to load data from database to show on grid
        //
        void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"Select orderId, orderDate, totalAmount, status, trackingNumber 
                                 from GameStore.dbo.Orders where userId = @userid";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@userid", this.userId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.order_grid.DataSource = dt;
            }
        }

        private void order_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.order_grid.SelectedRows.Count <= 0) return;

            int orderId = (int)this.order_grid.SelectedRows[0].Cells["orderId"].Value;

            OrderDetails orderdetails = new OrderDetails(this.connectionString, orderId);
            orderdetails.ShowDialog();
        }

        //
        // Event handler for click on cell in grid 
        //
        private void order_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if the clicked cell is header cell, if yes then return back 
            if (e.RowIndex < 0) return;

            // check if the check cell is in gird is a check box column or not 
            if (order_grid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                bool isChecked = (bool)(order_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? false);
                order_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;
                return;
            }

            int orderId = (int)this.order_grid.Rows[e.RowIndex].Cells["orderId"].Value;
            OrderDetails orderdetails = new OrderDetails(this.connectionString, orderId);
            orderdetails.ShowDialog();
        }

        //
        // Event to handle payment method etc. 
        //
        private void mkPayment_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.order_grid.Rows)
            {
                if (this.paymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value == true)
                {
                    int trsaction_id = new Random().Next(100000, 999999);
                    string payment_method = paymentMethod.Text;
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        connection.Open();
                        string query = @"Insert into GameStore.dbo.Payment Values
                               (@orderId, @date, @payment_status, @payment_method, @transactionsId, @amount)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@orderId", (int)row.Cells["orderId"].Value);
                            cmd.Parameters.AddWithValue("@date", DateTime.UtcNow);
                            cmd.Parameters.AddWithValue("@payment_status", "completed");
                            cmd.Parameters.AddWithValue("@payment_method", payment_method);
                            cmd.Parameters.AddWithValue("@transactionsId", trsaction_id);
                            cmd.Parameters.AddWithValue("@amount", (decimal)row.Cells["amount"].Value);

                            cmd.ExecuteNonQuery();
                        }

                        string updateQuery = @"Update GameStore.dbo.Orders set status = 'delivered' where orderId = @orderId";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@orderId", (int)row.Cells["orderId"].Value);
                            cmd.ExecuteNonQuery();
                        }
                        break;        // to ensure only one order is selected and payed
                    }
                }
            }
            LoadData();
            MessageBox.Show("Payment has been made successfully for one Order", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // Event to handle return and refund functionality 
        //
        private void refundBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in order_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value == true)
                    {
                        string query = @"Update GameStore.dbo.Orders set status = 'cancelled' where orderId = @orderid";
                        string updateInventoryquery = @"UPDATE i SET i.quantity = i.quantity + od.quantity
                                                        FROM GameStore.dbo.Inventory i
                                                        INNER JOIN GameStore.dbo.OrderDetails od ON i.gameId = od.gameId
                                                        WHERE od.orderId = @orderId";
                        string updatePyamentquery = @"Update GameStore.dbo.Payment set payment_status = 'refunded' where orderId = @orderId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@orderid", (int)row.Cells["orderId"].Value);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(updateInventoryquery, con))
                        {
                            cmd.Parameters.AddWithValue("@orderId", (int)row.Cells["orderId"].Value);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(updatePyamentquery, con))
                        {
                            cmd.Parameters.AddWithValue("@orderId", (int)row.Cells["orderId"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                // Refresh the grid after updating
                LoadData();

                MessageBox.Show("Your request has been approved. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
