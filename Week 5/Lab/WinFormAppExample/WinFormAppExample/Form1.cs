using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppExample
{
    public partial class frmEmployeeDetail : Form
    {
        public frmEmployeeDetail()
        {
            InitializeComponent();
        }

        private Label lbEmployeeDetailTitle;
        private Label lbEmployeeID;

        private void InitializeComponent()
        {
            this.lbEmployeeDetailTitle = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeePhone = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbEmployeeDegree = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployeeDetailTitle
            // 
            this.lbEmployeeDetailTitle.AutoSize = true;
            this.lbEmployeeDetailTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeDetailTitle.Location = new System.Drawing.Point(323, 55);
            this.lbEmployeeDetailTitle.Name = "lbEmployeeDetailTitle";
            this.lbEmployeeDetailTitle.Size = new System.Drawing.Size(239, 37);
            this.lbEmployeeDetailTitle.TabIndex = 0;
            this.lbEmployeeDetailTitle.Text = "Employee Details";
            this.lbEmployeeDetailTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(177, 130);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(73, 15);
            this.lbEmployeeID.TabIndex = 1;
            this.lbEmployeeID.Text = "Employee ID";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(177, 178);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(94, 15);
            this.lbEmployeeName.TabIndex = 2;
            this.lbEmployeeName.Text = "Employee Name";
            this.lbEmployeeName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbEmployeePhone
            // 
            this.lbEmployeePhone.AutoSize = true;
            this.lbEmployeePhone.Location = new System.Drawing.Point(177, 225);
            this.lbEmployeePhone.Name = "lbEmployeePhone";
            this.lbEmployeePhone.Size = new System.Drawing.Size(41, 15);
            this.lbEmployeePhone.TabIndex = 3;
            this.lbEmployeePhone.Text = "Phone";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(177, 269);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(45, 15);
            this.lb.TabIndex = 4;
            this.lb.Text = "Gender";
            // 
            // lbEmployeeDegree
            // 
            this.lbEmployeeDegree.AutoSize = true;
            this.lbEmployeeDegree.Location = new System.Drawing.Point(177, 313);
            this.lbEmployeeDegree.Name = "lbEmployeeDegree";
            this.lbEmployeeDegree.Size = new System.Drawing.Size(44, 15);
            this.lbEmployeeDegree.TabIndex = 5;
            this.lbEmployeeDegree.Text = "Degree";
            this.lbEmployeeDegree.Click += new System.EventHandler(this.lbEmployeeDegree_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(323, 130);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 23);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(323, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 23);
            this.txtName.TabIndex = 7;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(323, 225);
            this.mtxtPhone.Mask = "000-0000000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(239, 23);
            this.mtxtPhone.TabIndex = 8;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(323, 269);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(51, 19);
            this.rdMale.TabIndex = 9;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(453, 267);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(63, 19);
            this.rdFemale.TabIndex = 10;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cboDegree
            // 
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Items.AddRange(new object[] {
            "Ph.D",
            "Master",
            "Engineer",
            "Bachelor",
            "Technician"});
            this.cboDegree.Location = new System.Drawing.Point(323, 314);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(239, 23);
            this.cboDegree.TabIndex = 11;
            this.cboDegree.Text = "-----Selected-----";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEmployeeDetail
            // 
            this.ClientSize = new System.Drawing.Size(866, 516);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbEmployeeDegree);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbEmployeePhone);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.lbEmployeeDetailTitle);
            this.Name = "frmEmployeeDetail";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label lbEmployeeName;
        private Label lbEmployeePhone;
        private Label lb;
        private Label lbEmployeeDegree;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbEmployeeDegree_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtID;
        private TextBox txtName;
        private MaskedTextBox mtxtPhone;
        private RadioButton rdMale;
        private RadioButton rdFemale;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtID.Text;
            string EmployeeName = txtName.Text;
            string Phone = mtxtPhone.Text;
            string Gender = (rdFemale.Checked ? "Female" : "Male");
            string Degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"EmployeeID: {EmployeeID}");
            builder.Append($"EmployeeName: {EmployeeName}");
            builder.Append($"Phone: {Phone}");
            builder.Append($"Gender: {Gender}");
            builder.Append($"Degree: {Degree}");
            MessageBox.Show(builder.ToString(), "Employee Details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
