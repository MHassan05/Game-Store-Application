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

namespace GameStore
{
    public partial class DeleteProduct : Form
    {
        private string conString;
        public DeleteProduct(string connectionString)
        {
            InitializeComponent();
            this.productGridView.AutoGenerateColumns = false;
            this.conString = connectionString;
            loadGameData();
        }

        public void loadGameData()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "Select gameid, gametitle , price from GameStore.dbo.games";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.productGridView.DataSource = dt;
                productGridView.AutoGenerateColumns = false;
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!this.confirmCB.Checked)
            {
                MessageBox.Show("Please confirm the deletion", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in productGridView.Rows)
                {
                    if (row.Cells["delete_opt"].Value != null && (bool)row.Cells["delete_opt"].Value)
                    {
                        int gameId = Convert.ToInt32(row.Cells["gameid"].Value);
                        string query = "delete from GameStore.dbo.games where gameid = @gameid";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@gameid", gameId);
                        cmd.ExecuteNonQuery();

                        rowsToDelete.Add(row);
                    }
                }

                foreach (DataGridViewRow row in rowsToDelete)
                {
                    productGridView.Rows.Remove(row);
                }
                confirmCB.Checked = false;
            }

            MessageBox.Show("Product Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
