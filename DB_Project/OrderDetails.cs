using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class OrderDetails : Form
    {
        private string connectionString;
        private int requireId;
        public OrderDetails(string connectionString, int orderId)
        {
            InitializeComponent();
            this.requireId = orderId;
            this.connectionString = connectionString;
            this.orderDetail_grid.AutoGenerateColumns = false;
            LoadData();
        }

        //
        // Function to load data from database to show on grid
        //
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                con.Open();
                string query = @"SELECT od.orderDetailId, od.orderId, od.gameId, g.gametitle, od.quantity, od.pricePerUnit 
                                 FROM GameStore.dbo.OrderDetails od
                                 JOIN GameStore.dbo.Games g ON od.gameId = g.gameid
                                 where orderId = @orderid";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@orderid", this.requireId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.orderDetail_grid.DataSource = dt;
            }
        }
    }
}
