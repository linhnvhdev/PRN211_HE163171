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
    public partial class frmMember : Form
    {

        public MemberObject loginMember;
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        BindingSource citySource;
        BindingSource countrySource;

        bool search = false;
        bool filter = false;
        IEnumerable<MemberObject> dataSource;
        IEnumerable<MemberObject> searchResult;
        IEnumerable<MemberObject> filterResult;
        public frmMember()
        {
            InitializeComponent();
        }

        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            ToolStripMenuItem menuManagement = new ToolStripMenuItem("&Management");
            ToolStripMenuItem menuProductMng = new ToolStripMenuItem("&Product Management");
            ToolStripMenuItem menuOrderMng = new ToolStripMenuItem("&Order Management");
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

            // Main Menu
            mainMenu.Items.AddRange(new ToolStripItem[]
            {
                menuManagement,
                menuExit
            });

            // Menu Management
            menuManagement.DropDownItems.AddRange(new ToolStripItem[]
            {
                menuProductMng,
                menuOrderMng
            });

            menuProductMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.P);
            menuOrderMng.ShortcutKeys = (Keys)((Keys.Control) | Keys.O);

            menuProductMng.Click += new EventHandler(menuProductMng_Click);
            menuOrderMng.Click += new EventHandler(menuOrderMng_Click);
            menuExit.Click += new EventHandler(menuExit_Click);
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOrderMng_Click(object sender, EventArgs e)
        {
            frmOrder form = new frmOrder
            {
                loginMember = this.loginMember
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void menuProductMng_Click(object sender, EventArgs e)
        {
            frmProduct form = new frmProduct()
            {
                loginMember = this.loginMember
            };
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtMemberID.Enabled = false;
            txtEmail.Enabled = false;
            txtCompanyName.Enabled = false;
            txtPassword.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            btnNew.Enabled = false;
            dgvMemberList.Enabled = false;
            btnLoad.Enabled = true;
            grSearch.Enabled = false;
            grFilter.Enabled = false;
            CreateMainMenu();
        }

        private MemberObject GetMemberInfo()
        {
            MemberObject mem = null;
            try
            {
                mem = new MemberObject
                {
                    Id = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mem;
        }

        private void LoadMemberList()
        {
            dataSource = memberRepository.GetAllMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = dataSource;
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "Id");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (dataSource.Count() > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail form = new frmMemberDetail
            {
                MemberInfo = this.loginMember,
                InsertOrUpdate = true,
                Text = "Add new member"
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            dgvMemberList.Enabled = true;
            btnLoad.Enabled = true;
            grSearch.Enabled = true;
            grFilter.Enabled = true;
            LoadMemberList();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            frmMemberDetail form = new frmMemberDetail
            {
                MemberInfo = this.loginMember,
                InsertOrUpdate = true,
                Text = "Add new member"
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetMemberInfo();
                if (member.Id == loginMember.Id)
                {
                    MessageBox.Show("You can't delete yourself!!", "Delete member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show($"Do you really want to delete the member: \n" +
                    $"Member ID: {member.Id}\n" +
                    $"Email: {member.Email}\n" +
                    $"City: {member.City}\n" +
                    $"Country: {member.Country}", "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IEnumerable<OrderObject> orders = orderRepository.GetOrdersByMemberId(member.Id);
                        memberRepository.DeleteMember(member.Id);
                        search = false;
                        LoadMemberList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberObject member = GetMemberInfo();

            frmMemberDetail form = new frmMemberDetail
            {
                InsertOrUpdate = false,
                MemberInfo = member,
                Text = "Update member info"
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
    }
}
