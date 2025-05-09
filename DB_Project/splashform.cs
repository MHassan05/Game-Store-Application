using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class splashform : Form
    {
        private string connectionString;

        public splashform()
        {
            InitializeComponent();
           // Replace with your actual server connection string.
            connectionString = "your-connection-string-here";

            progress_bar.Minimum = 0;
            progress_bar.Maximum = 100;
            progress_bar.Value = 0;

            this.loading_label.Hide();
            this.progress_bar.Hide();
            this.login_hide_checkbox.Checked = true;
            this.password_textbox.UseSystemPasswordChar = true;
        }

        private async void login_button_Click(object sender, EventArgs e)
        {
            // Checking if all the fields are filled or not 
            if (
                string.IsNullOrEmpty(username_textbox.Text) ||
                string.IsNullOrEmpty(password_textbox.Text) ||
                rollbox.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Showing the loading label and progress bar
            this.loading_label.Show();
            this.progress_bar.Show();
            this.loading_label.Text = "Loading...";
            this.progress_bar.Value = 0;

            for (int i = 0; i <= progress_bar.Maximum; i++)
            {
                progress_bar.Value = i;
                await Task.Delay(5);
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string role = rollbox.SelectedItem.ToString().ToLower();
                String Query = @"SELECT COUNT(*) FROM GameStore.dbo.Users where
                                   Username=@username and UserPassword = @userpassword and UserRole=@userrole";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@username", username_textbox.Text);
                cmd.Parameters.AddWithValue("@userpassword", password_textbox.Text);
                cmd.Parameters.AddWithValue("@userrole", role);
                int count = (int)cmd.ExecuteScalar();

                // reset and hide the loading label and progress bar
                progress_bar.Value = 0;
                loading_label.Hide();
                progress_bar.Hide();

                if (count > 0)
                {
                    if (role == "admin")
                    {
                        this.Hide();
                        var admin = new adminform(username_textbox.Text, connectionString);
                        admin.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        this.Hide();
                        var customer = new Customer(connectionString, username_textbox.Text);
                        customer.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error! There's no " + username_textbox.Text + " exists.\nTry Creating New Account",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_hide_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (login_hide_checkbox.Checked)
            {
                password_textbox.UseSystemPasswordChar = true;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = false;
            }
        }

        //
        // Event to add/register new User(Customer)
        //
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registration = new Registration(connectionString, "customer");
            registration.ShowDialog();
            this.Show();
        }
    }

}
