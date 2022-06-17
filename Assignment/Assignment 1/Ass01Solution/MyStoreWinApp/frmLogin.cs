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

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        DataAccess.Repository.IMemberRepository memberRepository = new DataAccess.Repository.MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            var memberList = memberRepository.GetMemberList();
            var member =
                from m
                in memberRepository.GetMemberList()
                where m.Email.Equals(email) && m.Password.Equals(password)
                select m;
            if(member.Count() == 0)
            {
                MessageBox.Show("Wrong username or password!!","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Member CurrentMember = member.FirstOrDefault();
                ClearText();
                this.Hide();
                frmMemberManagement mainForm = new frmMemberManagement()
                {
                    CurrentMemberAccount = CurrentMember
                };
                mainForm.Owner = this;
                mainForm.Show();
                //this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
