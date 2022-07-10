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
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        IMemberRepository _memberRepository = new MemberRepository();

        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                //txtMemberID.Text = MemberRepository.GetNextMemberId().ToString();

            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtMemberID.Enabled = false;

                txtMemberID.Text = MemberInfo.Id.ToString();
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtConfirm.Text = MemberInfo.Password;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;

                if (!MemberInfo.Email.Equals("admin@fstore.com"))
                {
                    MenuStrip mainMenu = new MenuStrip();
                    this.Controls.Add(mainMenu);
                    this.MainMenuStrip = mainMenu;

                    ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
                    //ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
                    ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                    // Main Menu
                    mainMenu.Items.AddRange(new ToolStripItem[]
                    {
                        menuOrder,
                        menuExit
                    });

                    menuOrder.Click += new EventHandler(menuOrder_Click);
                    menuExit.Click += new EventHandler(menuExit_Click);
                }
            }
        }

        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmProduct form = new frmProduct()
            {
                loginMember = MemberInfo
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                MemberObject member = new MemberObject()
                {
                    Id = MemberInfo.Id,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                _memberRepository.UpdateMember(member);

                MessageBox.Show("Update successfully!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                MemberObject member = new MemberObject()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                _memberRepository.InsertMember(member);

                MessageBox.Show("Add successfully!!", "Add member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                MemberObject member = new MemberObject()
                {
                    Id = MemberInfo.Id,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                _memberRepository.InsertMember(member);

                MessageBox.Show("Update successfully!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
