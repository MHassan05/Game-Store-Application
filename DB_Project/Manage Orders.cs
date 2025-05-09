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
    public partial class Manage_Orders : Form
    {
        private string conString;
        public Manage_Orders(string connectionString)
        {
            InitializeComponent();
            this.conString = connectionString;
            LoadData();
            loadComboBox();
        }

        //
        // function to load data from database 
        //
        private void LoadData(string q = "")
        {
            string query = @"Select orderId, userId, orderDate, totalAmount, status, trackingNumber 
                                 from GameStore.dbo.Orders";
            if (q != "")
            {
                query += q;
            }
            using (SqlConnection con = new SqlConnection(this.conString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con); 
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.order_grid.DataSource = dt;
            }
        }

        //
        // function to load combo box
        //
        private void loadComboBox()
        {
           userCMB.SelectedIndexChanged -= userCMB_SelectedIndexChanged;
            userCMB.Items.Clear();

            using (SqlConnection con = new SqlConnection(this.conString))
            {
                con.Open();
                string query = @"SELECT UserId, Username FROM GameStore.dbo.Users WHERE UserRole = 'customer'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        userCMB.DisplayMember = "Username";
                        userCMB.ValueMember = "UserId";
                        userCMB.DataSource = dt;
                    }
                }
            }
          userCMB.SelectedIndexChanged += userCMB_SelectedIndexChanged;
        }

        private void order_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (order_grid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                /* null-coalescing operator- isChecked = someValue ?? defaultValue;
                 * if someValue is null then defaultValue will be assigned to isChecked
                 */
                bool isChecked = (bool)(order_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? false);
                order_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;
                return;
            }

            int orderId = (int)this.order_grid.Rows[e.RowIndex].Cells["orderId"].Value;
            OrderDetails orderdetails = new OrderDetails(this.conString, orderId);
            orderdetails.ShowDialog();
        }

        //
        // Event handler for cancel button
        //
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.conString))
            {
                con.Open();

                foreach (DataGridViewRow row in this.order_grid.Rows)
                {
                    if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                    {
                        // checking order if it's delivered
                        string status = row.Cells["status"].Value.ToString();
                        if (status == "delivered")
                        {
                            MessageBox.Show("You cannot cancel a delivered order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int orderId = (int)row.Cells["orderId"].Value;
                        string query = @"Update GameStore.dbo.Orders 
                                         set status = 'cancelled' 
                                         where orderId = @orderId";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@orderId", orderId);
                            cmd.ExecuteNonQuery();
                        }

                        // updating inventory 
                        string query2 = @"UPDATE i SET i.quantity = i.quantity + od.quantity
                                                        FROM GameStore.dbo.Inventory i
                                                        INNER JOIN GameStore.dbo.OrderDetails od ON i.gameId = od.gameId
                                                        WHERE od.orderId = @orderId";
                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            cmd.Parameters.AddWithValue("@orderId", orderId);
                            cmd.ExecuteNonQuery();
                        }

                    }
                }

                // refresh grid 
                LoadData();
                MessageBox.Show("Selected orders have been cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }

        private void userCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userCMB.SelectedValue == DBNull.Value || userCMB.SelectedValue == null)
            {
                LoadData(); 
                return;
            }
            // interpolating variables
            DataRowView selectedRow = (DataRowView)userCMB.SelectedItem;
            int userId = Convert.ToInt32(selectedRow["UserId"]);
            string query = $" WHERE UserId = {userId};";
            LoadData(query);
            
        }
    }
}
