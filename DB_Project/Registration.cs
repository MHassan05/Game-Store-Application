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
using System.Net.Configuration;
using System.Windows.Forms.VisualStyles;

namespace GameStore
{
    public partial class Registration : Form
    {
        private string conString;
        private string userrole;

        public Registration(string connectionString, String role = "customer")
        {
            InitializeComponent();
            this.userrole = role.ToLower();
            this.passwordbox.UseSystemPasswordChar = true; this.hidepassword.Checked = true;
            this.confirmpasswordbox.UseSystemPasswordChar = true; this.hideConfirmPassword.Checked = true;
            this.conString = connectionString;

            // if the user is not a customer, hide the address box and label
            if (this.userrole != "customer")
            {
                this.addressbox.Hide();
                this.addressLabel.Hide();
            }
            else
            {
                this.addressbox.Show();
                this.addressLabel.Show();
            }
        }

        // function to validate the required fields
        private bool isValid()
        {
            if (
               string.IsNullOrWhiteSpace(this.username.Text) ||
               string.IsNullOrWhiteSpace(this.passwordbox.Text) ||
               string.IsNullOrWhiteSpace(this.confirmpasswordbox.Text) ||
               string.IsNullOrWhiteSpace(this.emailbox.Text)
               )
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }

            if (this.userrole == "customer" && string.IsNullOrWhiteSpace(this.addressbox.Text))
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }

            if (!this.conditionsButton.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.passwordbox.Text != this.confirmpasswordbox.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checking if all the fields are filled or not
            if (!isValid())
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(this.conString))
            {
                con.Open();
                try
                {
                    String query = @"Insert into GameStore.dbo.Users(Username, UserPassword, Email, UserRole, shippingAddress)
                                    values(@username, @userpassword, @email, @role, @address)";

                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@userpassword", passwordbox.Text);
                        cmd.Parameters.AddWithValue("@email", emailbox.Text);
                        cmd.Parameters.AddWithValue("@role", this.userrole);
                        cmd.Parameters.AddWithValue("@address", this.userrole == "customer" ? addressbox.Text : "N/A");
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful\nPress Okay to Exit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        String query = @"Select * from GameStore.dbo.Users where Username = @username";
                        string msg = "";
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            msg = count > 0 ? "Username" : "Email";
                        }
                        MessageBox.Show(msg + " already Exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void hidepassword_CheckedChanged(object sender, EventArgs e)
        {
            if (hidepassword.Checked)
            {
                this.passwordbox.UseSystemPasswordChar = true;
            }
            else
            {
                this.passwordbox.UseSystemPasswordChar = false;
            }
        }

        private void hideConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (hideConfirmPassword.Checked)
            {
                this.confirmpasswordbox.UseSystemPasswordChar = true;
            }
            else
            {
                this.confirmpasswordbox.UseSystemPasswordChar = false;
            }
        }
    }
}
