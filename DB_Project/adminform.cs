using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class adminform : Form
    {
        private string conString;
        public adminform(string username, string connectionString)
        {
            InitializeComponent();
            this.conString = connectionString;

            this.welcome_back_label.Text = "Welcome back,\n" + username.ToLower() + "! ";
            this.welcome_back_label.TextAlign = ContentAlignment.MiddleCenter;

            // Line to separate the logo, buttons from Products
            this.line_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.line_panel.Height = 1;
            this.line_panel.Width = this.ClientSize.Width;
            this.line_panel.Location = new Point(0, 200); 
        }

        //
        // Event to Add new User(Admin)
        //
        private void add_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerAdmin = new Registration(this.conString, "admin");
            registerAdmin.ShowDialog();
            this.Show();
        }

        //
        // Event to Add new Genre 
        //
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addGenre = new AddGenreFrom(conString);
            addGenre.ShowDialog();
            this.Show();
        }

        //
        // Event to Add new Platform
        //
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addPlatform = new AddPlatform(conString);
            addPlatform.ShowDialog();
            this.Show();
        }

        //
        // Event to insert new Product/Game in database;
        //
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var insertItem = new Insert_Item(conString);
            insertItem.ShowDialog();
            this.Show();
        }

        //
        // Even to delete a product/game from the database;
        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteProduct = new DeleteProduct(conString);
            deleteProduct.ShowDialog();
            this.Show();
        }

        private void mng_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Orders manage_Orders = new Manage_Orders(this.conString);
            manage_Orders.ShowDialog();
            this.Show();
        }
    }
}
