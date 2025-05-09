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
using Microsoft.IdentityModel.Tokens;

namespace GameStore
{
    public partial class AddGenreFrom : Form
    {
        private string conString;
        
        public AddGenreFrom(string ConnectionString)
        {
            InitializeComponent();
            this.conString = ConnectionString;
        }

        private void add_genere_button_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.add_genere_text.Text)
                )
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // checking if the genre already exists
                string query = "Select genrename from GameStore.dbo.genre where genrename = @genrename";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@genrename", this.add_genere_text.Text);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("This genre already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the new genre
                query = "Insert into GameStore.dbo.genre (genrename) values (@genrename)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@genrename", this.add_genere_text.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Genre added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
