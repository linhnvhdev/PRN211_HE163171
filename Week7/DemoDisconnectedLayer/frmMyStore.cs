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

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }

        DataSet dsMyStore = new DataSet();

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMyStore_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=(local); uid=sa; pwd=Yotsugi123;database=MyStore;Encrypt=False";
            string sql = "SELECT ProductID, ProductName, UnitInStock From Products; Select * From Categories";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, ConnectionString);
                adapter.Fill(dsMyStore);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data from db");
            }
        }
    }
}
