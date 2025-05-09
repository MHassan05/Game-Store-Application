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
using System.Runtime.InteropServices;

namespace GameStore
{
    public partial class Insert_Item : Form
    {
        // Dictionary to map genres and platforms to their repective IDs
        private Dictionary<string, int> genreMap = new Dictionary<string, int>();
        private Dictionary<string, int> platformMap = new Dictionary<string, int>();
        private string conString;

        public void load_Genres_Platform()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand genrecmd = new SqlCommand("SELECT genreid, genrename FROM GameStore.dbo.genre", con))
                using (SqlDataReader genreReader = genrecmd.ExecuteReader())
                {
                    while (genreReader.Read())
                    {
                        string name = genreReader["genrename"].ToString();
                        int id = Convert.ToInt32(genreReader["genreid"]);

                        this.cblGenre.Items.Add(name);
                        genreMap.Add(name, id);
                    }
                }

                using (SqlCommand platformCMD = new SqlCommand("SELECT platformid, platformname FROM GameStore.dbo.platform", con))
                using (SqlDataReader platformReader = platformCMD.ExecuteReader())
                {
                    while (platformReader.Read())
                    {
                        string name = platformReader["platformname"].ToString();
                        int id = Convert.ToInt32(platformReader["platformid"]);
                        this.cblPlatform.Items.Add(name);
                        platformMap.Add(name, id);
                    }
                }
            }

        }

        public Insert_Item(string connectionString)
        {
            InitializeComponent();
            this.conString = connectionString;
            load_Genres_Platform();
        }

        //
        // This method is called when the user clicks the "Insert" button.
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(this.textGameName.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(this.textDescription.Text) ||
                string.IsNullOrEmpty(this.textQuantity.Text) ||
                cblGenre.CheckedItems.Count == 0 ||
                cblPlatform.CheckedItems.Count == 0
                )
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate price and quantity
            decimal price;
            int quantity;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.textQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the game into the database

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();


                string CheckQuery = @"SELECT COUNT(*) FROM GameStore.dbo.games WHERE gametitle = @title";
                int count = 0;

                // Check if the game already exists in the database
                using (SqlCommand checkCmd = new SqlCommand(CheckQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@title", this.textGameName.Text);
                    count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Game already exists in the database.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert the item in database 
                string InsertQuery = @"INSERT INTO GameStore.dbo.games (gametitle, description, price)
                       VALUES (@title, @description, @price)";
                using (SqlCommand insertCmd = new SqlCommand(InsertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@title", this.textGameName.Text);
                    insertCmd.Parameters.AddWithValue("@description", this.textDescription.Text);
                    insertCmd.Parameters.AddWithValue("@price", (int)price);
                    if (insertCmd.ExecuteNonQuery() < 0)
                    {
                        MessageBox.Show("Failed to insert game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Get the game ID of the newly inserted game
                string gameIdQuery = "SELECT gameid FROM GameStore.dbo.games WHERE gametitle = @name";

                SqlCommand cmd = new SqlCommand(gameIdQuery, con);
                cmd.Parameters.AddWithValue("@name", this.textGameName.Text);
                int gameId = (int)cmd.ExecuteScalar();

                string insertInventoryQuery = "INSERT INTO GameStore.dbo.Inventory (gameId, quantity) VALUES (@gameId, @quantity)";
                SqlCommand invCmd = new SqlCommand(insertInventoryQuery, con);
                invCmd.Parameters.AddWithValue("@gameId", gameId);
                invCmd.Parameters.AddWithValue("@quantity", quantity);
                invCmd.ExecuteNonQuery();

                // Insert the selected genres and platform into the database
                if (gameId > 0)
                {
                    // Insert the selected platforms into the database
                    foreach (string genre in cblGenre.CheckedItems)
                    {
                        int genreId = genreMap[genre];
                        string insertGenreQuery = "INSERT INTO GameStore.dbo.games_genre (gameid, genreid) VALUES (@gameId, @genreId)";
                        cmd = new SqlCommand(insertGenreQuery, con);
                        cmd.Parameters.AddWithValue("@gameId", gameId);
                        cmd.Parameters.AddWithValue("@genreId", genreId);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert the selected platforms into the database
                    foreach (string platform in cblPlatform.CheckedItems)
                    {
                        int platformId = platformMap[platform];
                        string insertPlatformQuery = "INSERT INTO GameStore.dbo.games_platform (gameid, platformid) VALUES (@gameId, @platformId)";
                        cmd = new SqlCommand(insertPlatformQuery, con);
                        cmd.Parameters.AddWithValue("@gameId", gameId);
                        cmd.Parameters.AddWithValue("@platformId", platformId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Game inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
