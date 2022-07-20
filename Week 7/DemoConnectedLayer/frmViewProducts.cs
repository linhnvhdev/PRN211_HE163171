using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DemoConnectedLayer
{
    public partial class frmViewProducts : Form
    {
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>();
            string ConnectionString = "Server=(local); uid=sa; pwd=Yotsugi123;database=MyStore;Encrypt=False";
            SqlConnection conn = new SqlConnection(ConnectionString);
            
            SqlCommand command = new SqlCommand("Select ProductName, UnitPrice from Products", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                products.Add(new
                {
                    ProductName = reader.GetString("ProductName"),
                    UnitPrice = reader.GetDecimal("UnitPrice")

                });
            }
            dataGridView1.DataSource = products;
        }
    }
}
