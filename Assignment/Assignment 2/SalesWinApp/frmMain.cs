using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public MemberObject loginMember;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            frmMember form = null;
            form = new frmMember
            {
                loginMember = this.loginMember
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProduct form = new frmProduct()
            {
                loginMember = this.loginMember
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrder form = new frmOrder
            {
                loginMember = this.loginMember
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }
    }
}
