using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;


namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool IsAdd { get; set; }
        public Member MemberInfo { get; set; }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = IsAdd;
            txtPassword.UseSystemPasswordChar = true;
            if (!IsAdd)
            {
                txtID.Text = MemberInfo.MemberID.ToString();
                txtName.Text = MemberInfo.MemberName.ToString();
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPassword.Text = MemberInfo.Password.ToString();
                txtCity.Text = MemberInfo.City.ToString();
                txtCountry.Text = MemberInfo.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member()
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (IsAdd)
                {
                    MemberRepository.AddMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, IsAdd ? "When add" : "When update");
            }
        }
    }
}
