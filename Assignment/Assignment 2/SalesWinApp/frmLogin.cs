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
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = txtEmail.Text;
                string Password = txtPassword.Text;
                MemberObject loginMember = memberRepository.GetMember(Email, Password);
                if (loginMember != null)
                {
                    MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Email.Equals("admin@fstore.com"))
                    {
                        frmMain formMain = null;
                        formMain = new frmMain
                        {
                            loginMember = loginMember
                        };
                        formMain.Closed += (s, args) => this.Close();
                        this.Hide();
                        formMain.Show();
                    }
                    else
                    {
                        frmProduct formProduct = new frmProduct()
                        {
                            loginMember = loginMember
                        };
                        formProduct.Closed += (s, args) => this.Close();
                        this.Hide();
                        formProduct.Show();
                    }
                }
                else
                {
                    if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
