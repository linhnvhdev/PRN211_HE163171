using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Repository;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        public Member CurrentMemberAccount { get; set; }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            DisableTextField();
            
            LoadMemberList();
            // Set filter value

            if (isAdminAccount(CurrentMemberAccount))
            {
                dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            }
            else
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private bool isAdminAccount(Member member)
        {
            return member.Email.Equals("admin@fstore.com");
        }

        private void DisableTextField()
        {
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtCountry.ReadOnly = true;
        }

        private void LoadMemberList()
        {
            Reset();
            var memberList = (isAdminAccount(CurrentMemberAccount)) ? memberRepository.GetMemberList() 
                                                                    : new[] { memberRepository.GetMemberByID(CurrentMemberAccount.MemberID) };
            BindDataGridView(memberList);
        }

        private void Reset()
        {
            txtID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtCountry.Text = String.Empty;
            txtSearchName.Text = String.Empty;
            txtSearchID.Text = String.Empty;

            cboFilterCity.SelectedIndexChanged -= cboFilterCity_SelectedIndexChanged;
            cboFilterCountry.SelectedIndexChanged -= cboFilterCountry_SelectedIndexChanged;
            cboSortByName.SelectedIndexChanged -= cboSortByName_SelectedIndexChanged;
            cboFilterCountry.SelectedIndex = 0;
            cboFilterCity.SelectedIndex = 0;
            cboSortByName.SelectedIndex = 0;
            cboFilterCity.SelectedIndexChanged += cboFilterCity_SelectedIndexChanged;
            cboFilterCountry.SelectedIndexChanged += cboFilterCountry_SelectedIndexChanged;
            cboSortByName.SelectedIndexChanged += cboSortByName_SelectedIndexChanged;
        }

        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails memberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                IsAdd = false,
                MemberRepository = memberRepository,
                MemberInfo = getCurrentMember(),
            };
            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private Member getCurrentMember()
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
            return member;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails memberDetails = new frmMemberDetails
            {
                Text = "Add Member",
                IsAdd = true,
                MemberRepository = memberRepository
            };
            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = getCurrentMember();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void dgvMemberList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvMemberList.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length) ;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails memberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                IsAdd = false,
                MemberRepository = memberRepository,
                MemberInfo = getCurrentMember(),
            };
            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSearchID.Text == String.Empty && txtSearchName.Text == String.Empty)
                {
                    LoadMemberList();
                    return;
                }
                int? searchID = int.TryParse(txtSearchID.Text, out _) ? int.Parse(txtSearchID.Text) : null;
                string searchName = txtSearchName.Text;
                IEnumerable<Member> memberList = from members
                                                 in (IEnumerable<Member>) source.DataSource
                                                 where (searchID == null || members.MemberID == searchID)
                                                        && (searchName == String.Empty || members.MemberName.Contains(searchName))
                                                 select members;
                if(memberList.Count() > 0)BindDataGridView(memberList);
                else
                {
                    MessageBox.Show("Can't find", "Find Fail");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"In Search");
            }
        }

        private void cboSortByName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboSortByName.Text.Equals("Ascending"))
            {
                sortMemberListAscending();
            }
            else if (cboSortByName.Text.Equals("Descending"))
            {
                sortMemberListDescending();
            }
            else
            {
                LoadMemberList();
            }
        }

        private void BindDataGridView(IEnumerable<Member> memberList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = memberList;
                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (memberList.Count() == 0)
                {
                    Reset();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                int indexCity = cboFilterCity.SelectedIndex == -1 ? 0 : cboFilterCity.SelectedIndex;
                int indexCountry = cboFilterCountry.SelectedIndex == -1 ? 0 : cboFilterCountry.SelectedIndex;
                string curSelectedValueCity = cboFilterCity.GetItemText(cboFilterCity.Items[indexCity]);
                string curSelectedValueCountry = cboFilterCountry.GetItemText(cboFilterCountry.Items[indexCountry]);
                cboFilterCity.SelectedIndexChanged -= cboFilterCity_SelectedIndexChanged;
                cboFilterCountry.SelectedIndexChanged -= cboFilterCountry_SelectedIndexChanged;
                cboFilterCity.Items.Clear();
                cboFilterCountry.Items.Clear();
                cboFilterCity.Items.Add("All");
                cboFilterCountry.Items.Add("All");
                string[] membersCity = ((IEnumerable<Member>)source.DataSource)
                .Select(m => m.City)
                .Distinct()
                .ToArray();
                string[] membersCountry = ((IEnumerable<Member>)source.DataSource)
                    .Select(m => m.Country)
                    .Distinct()
                    .ToArray();
                cboFilterCity.Items.AddRange(membersCity);
                cboFilterCountry.Items.AddRange(membersCountry);
                for (int i = 0; i < cboFilterCity.Items.Count; i++)
                {
                    string value = cboFilterCity.GetItemText(cboFilterCity.Items[i]);
                    if (curSelectedValueCity.Equals(value))
                        cboFilterCity.SelectedIndex = i;
                }
                for (int i = 0; i < cboFilterCountry.Items.Count; i++)
                {
                    string value = cboFilterCountry.GetItemText(cboFilterCountry.Items[i]);
                    if (curSelectedValueCountry.Equals(value))
                        cboFilterCountry.SelectedIndex = i;
                }
                
                cboFilterCity.SelectedIndexChanged += cboFilterCity_SelectedIndexChanged;
                cboFilterCountry.SelectedIndexChanged += cboFilterCountry_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "In Bind List");
            }
        }

        private void sortMemberListAscending()
        {
            IEnumerable<Member> memberList = from members
                                             in (IEnumerable <Member>) source.DataSource
                                             orderby members.MemberName ascending
                                             select members;
            BindDataGridView(memberList);
        }

        private void sortMemberListDescending()
        {
            IEnumerable<Member> memberList = from members
                                             in (IEnumerable<Member>)source.DataSource
                                             orderby members.MemberName descending
                                             select members;
            BindDataGridView(memberList);
        }

        private void frmMemberManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFilterCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterCountry.SelectedIndex == 0)
            {
                LoadMemberList();
                return;
            }
            string searchCountry = cboFilterCountry.Text;
            IEnumerable<Member> memberList = from members
                                             in (IEnumerable<Member>)source.DataSource
                                             where members.Country.Equals(searchCountry)
                                             select members;
            if (memberList.Count() > 0) BindDataGridView(memberList);
            else
            {
                MessageBox.Show("Can't find any member", "Find Fail");
            }
        }

        private void cboFilterCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterCity.SelectedIndex == 0)
            {
                LoadMemberList();
                return;
            }
            string searchCity = cboFilterCity.Text;
            IEnumerable<Member> memberList = from members
                                             in (IEnumerable<Member>)source.DataSource
                                             where members.City.Equals(searchCity)
                                             select members;
            if (memberList.Count() > 0) BindDataGridView(memberList);
            else
            {
                MessageBox.Show("Can't find any member", "Find Fail");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
    }
}
