namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new System.Windows.Forms.Label();
            this.ibName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lbSearchByName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cboFilterCountry = new System.Windows.Forms.ComboBox();
            this.lbFilterCountry = new System.Windows.Forms.Label();
            this.lbFilterCity = new System.Windows.Forms.Label();
            this.cboFilterCity = new System.Windows.Forms.ComboBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.lbSortByName = new System.Windows.Forms.Label();
            this.cboSortByName = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(40, 29);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 15);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // ibName
            // 
            this.ibName.AutoSize = true;
            this.ibName.Location = new System.Drawing.Point(40, 77);
            this.ibName.Name = "ibName";
            this.ibName.Size = new System.Drawing.Size(39, 15);
            this.ibName.TabIndex = 1;
            this.ibName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(286, 29);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(552, 29);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(552, 77);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(286, 77);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(81, 23);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(362, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(615, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(362, 69);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(141, 23);
            this.txtCountry.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(615, 69);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(103, 23);
            this.txtCity.TabIndex = 11;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(16, 170);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 12;
            this.lbSearch.Text = "Search";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(93, 227);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(155, 23);
            this.txtSearchName.TabIndex = 13;
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.AutoSize = true;
            this.lbSearchByName.Location = new System.Drawing.Point(16, 227);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(55, 15);
            this.lbSearchByName.TabIndex = 14;
            this.lbSearchByName.Text = "By Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "By ID";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(95, 190);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(75, 23);
            this.txtSearchID.TabIndex = 15;
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(615, 170);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(33, 15);
            this.lbFilter.TabIndex = 17;
            this.lbFilter.Text = "Filter";
            // 
            // cboFilterCountry
            // 
            this.cboFilterCountry.FormattingEnabled = true;
            this.cboFilterCountry.Items.AddRange(new object[] {
            "All"});
            this.cboFilterCountry.Location = new System.Drawing.Point(688, 195);
            this.cboFilterCountry.Name = "cboFilterCountry";
            this.cboFilterCountry.Size = new System.Drawing.Size(121, 23);
            this.cboFilterCountry.TabIndex = 18;
            this.cboFilterCountry.SelectedIndexChanged += new System.EventHandler(this.cboFilterCountry_SelectedIndexChanged);
            // 
            // lbFilterCountry
            // 
            this.lbFilterCountry.AutoSize = true;
            this.lbFilterCountry.Location = new System.Drawing.Point(615, 198);
            this.lbFilterCountry.Name = "lbFilterCountry";
            this.lbFilterCountry.Size = new System.Drawing.Size(50, 15);
            this.lbFilterCountry.TabIndex = 19;
            this.lbFilterCountry.Text = "Country";
            // 
            // lbFilterCity
            // 
            this.lbFilterCity.AutoSize = true;
            this.lbFilterCity.Location = new System.Drawing.Point(615, 227);
            this.lbFilterCity.Name = "lbFilterCity";
            this.lbFilterCity.Size = new System.Drawing.Size(28, 15);
            this.lbFilterCity.TabIndex = 20;
            this.lbFilterCity.Text = "City";
            // 
            // cboFilterCity
            // 
            this.cboFilterCity.FormattingEnabled = true;
            this.cboFilterCity.Items.AddRange(new object[] {
            "All"});
            this.cboFilterCity.Location = new System.Drawing.Point(688, 227);
            this.cboFilterCity.Name = "cboFilterCity";
            this.cboFilterCity.Size = new System.Drawing.Size(121, 23);
            this.cboFilterCity.TabIndex = 21;
            this.cboFilterCity.SelectedIndexChanged += new System.EventHandler(this.cboFilterCity_SelectedIndexChanged);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(12, 304);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.Size = new System.Drawing.Size(874, 225);
            this.dgvMemberList.TabIndex = 22;
            this.dgvMemberList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMemberList_CellFormatting);
            // 
            // lbSortByName
            // 
            this.lbSortByName.AutoSize = true;
            this.lbSortByName.Location = new System.Drawing.Point(377, 170);
            this.lbSortByName.Name = "lbSortByName";
            this.lbSortByName.Size = new System.Drawing.Size(79, 15);
            this.lbSortByName.TabIndex = 23;
            this.lbSortByName.Text = "Sort By Name";
            // 
            // cboSortByName
            // 
            this.cboSortByName.FormattingEnabled = true;
            this.cboSortByName.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.cboSortByName.Location = new System.Drawing.Point(377, 198);
            this.cboSortByName.Name = "cboSortByName";
            this.cboSortByName.Size = new System.Drawing.Size(121, 23);
            this.cboSortByName.TabIndex = 24;
            this.cboSortByName.SelectedIndexChanged += new System.EventHandler(this.cboSortByName_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(205, 123);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(362, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 264);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(734, 123);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(54, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 541);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cboSortByName);
            this.Controls.Add(this.lbSortByName);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.cboFilterCity);
            this.Controls.Add(this.lbFilterCity);
            this.Controls.Add(this.lbFilterCountry);
            this.Controls.Add(this.cboFilterCountry);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.lbSearchByName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.ibName);
            this.Controls.Add(this.lbID);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMemberManagement_FormClosed);
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label ibName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lbSearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox cboFilterCountry;
        private System.Windows.Forms.Label lbFilterCountry;
        private System.Windows.Forms.Label lbFilterCity;
        private System.Windows.Forms.ComboBox cboFilterCity;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbSortByName;
        private System.Windows.Forms.ComboBox cboSortByName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReset;
    }
}