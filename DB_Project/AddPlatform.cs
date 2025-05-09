using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace GameStore
{
    public partial class AddPlatform : Form
    {
        private string conString;
        public AddPlatform(string connectionString)
        {
            InitializeComponent();
            this.conString = connectionString;
        }

        private void add__button_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.name_text.Text)
                )
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // Check if the platform already exists
                string query = "Select platformname from GameStore.dbo.platform where platformname = @platformname";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@platformname", this.name_text.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("This platform already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the new platform
                query = "Insert into GameStore.dbo.platform (platformname) values (@platformname)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@platformname", this.name_text.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Platform added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
