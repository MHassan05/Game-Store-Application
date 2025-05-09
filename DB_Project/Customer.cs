using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameStore
{
    public partial class Customer : Form
    {
        private string connectionString;
        private string username;
        private int userId;
        public Customer(string connectionString, string username)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.product_grid.AutoGenerateColumns = false;
            this.username = username;
            this.userId = findUserId();

            this.welcome_back_label.Text = "Welcome back,\n" + username + " !";
            this.welcome_back_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Line to separate the logo, buttons from Products
            this.verticle_line_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.verticle_line_panel.Height = this.ClientSize.Height;
            this.verticle_line_panel.Width = 1;
            this.verticle_line_panel.Location = new Point(120, 0);

            loadData();
            loadComboBox();
        }

        //
        // Function to find user id from the database
        //
        private int findUserId()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT UserId FROM GameStore.dbo.Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", this.username);
                return (int)cmd.ExecuteScalar();
            }
        }

        //
        // Function to load data from database to show on grid 
        //
        private void loadData(string condition = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "Select * from GameStore.dbo.view_gamedisplay";

                if (condition != null)
                    query += condition;

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.product_grid.DataSource = dt;
            }
        }

        //
        // This function will load comboxes with their required fields
        //
        private void loadComboBox()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT platformname FROM GameStore.dbo.platform";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["platformname"].ToString();
                        platform_cmbx.Items.Add(name);
                    }
                }

                query = "SELECT genrename FROM GameStore.dbo.genre";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["genrename"].ToString();
                        genre_cmbx.Items.Add(name);
                    }
                }
            }
        }

        private void logout_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // This event will handle categorization by platform 
        //
        private void platform_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.genre_cmbx.SelectedIndexChanged -= genre_cmbx_SelectedIndexChanged;
            if (this.genre_cmbx.SelectedIndex > -1)
            {
                this.genre_cmbx.SelectedIndex = -1; 
            }
            this.genre_cmbx.SelectedIndexChanged += genre_cmbx_SelectedIndexChanged;

            string condition = " where platformname like '%" + platform_cmbx.SelectedItem.ToString() + "%'";
            loadData(condition);
        }

        //
        // This event will handle categorization by genre
        //
        private void genre_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.platform_cmbx.SelectedIndexChanged -= platform_cmbx_SelectedIndexChanged;
            if (this.platform_cmbx.SelectedIndex > -1)
            {
                this.platform_cmbx.SelectedIndex = -1;
            }
            this.platform_cmbx.SelectedIndexChanged += platform_cmbx_SelectedIndexChanged;

            string condition = " where genrename like '%" + genre_cmbx.SelectedItem.ToString() + "%'";
            loadData(condition);
        }

        private void add_to_cart_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in product_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                    {
                        int gameId = Convert.ToInt32(row.Cells["gameid"].Value);

                        // validating if the game is out of stock                
                        if (!isGameinStock(con, gameId))
                        {
                            MessageBox.Show("Game is out of stock", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // validating if the game is already in cart
                        if (isGameinCart(con, gameId))
                        {
                           string query = "update GameStore.dbo.Cart set quantity = quantity + 1 where gameId = @gameid and userId = @userid";
                           using (SqlCommand cmd = new SqlCommand(query, con))
                           {
                                cmd.Parameters.AddWithValue("@gameid", gameId);
                                cmd.Parameters.AddWithValue("@userid", this.userId);
                                cmd.ExecuteNonQuery();
                           }
                        }
                        else
                        {
                            string query = "insert into GameStore.dbo.Cart (gameId, userId, quantity) values (@gameid, @userid, 1)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@gameid", gameId);
                                cmd.Parameters.AddWithValue("@userid", this.userId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Reload the data to reflect changes
            loadData();

            MessageBox.Show("Game(s) added to cart successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //
        // Function to check if game is available in invenotry or not ?
        //
        private bool isGameinStock(SqlConnection con, int gameid)
        {
            string getQuantity = "Select quantity from GameStore.dbo.Inventory where gameid = @gameid";
            SqlCommand cmd = new SqlCommand(getQuantity, con);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            int quantity = (int)cmd.ExecuteScalar();

            return quantity > 0;
        }

        //
        // Function to check if game is in cart or not ?
        //
        private bool isGameinCart(SqlConnection con, int gameid)
        {
            string query = "Select Count(*) from GameStore.dbo.Cart where gameId = @gameid and userId = @userid";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userid", this.userId);
                cmd.Parameters.AddWithValue("@gameid", gameid);
                object result = cmd.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) > 0)
                {
                    return true; 
                }
                else
                {
                    return false;  
                }
            }
        }

        //
        // Event to show cart 
        //
        private void show_cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartedItem cart = new CartedItem(this.connectionString, this.userId);
            cart.ShowDialog();
            this.Show();
        }

        //
        // Event to show form for order details
        //
        private void show_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders(this.connectionString, this.userId);
            orders.ShowDialog();
            this.Show();
        }
    }
}

