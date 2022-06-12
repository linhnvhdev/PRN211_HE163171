using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMDIApp
{
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        int counter = 1;

        private void Main2_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }

        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem menuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuWindow = new ToolStripMenuItem("&Window");
            // main Menu
            mainMenu.Items.AddRange(new ToolStripMenuItem[] { menuFile, menuWindow });
            mainMenu.MdiWindowListItem = menuWindow;
            // menu File
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, toolStripSeparator, menuExit });
            // Menu Open
            menuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            menuOpen.Click += new EventHandler(menuOpen_Click);
            // Menu Open
            menuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            menuExit.Click += new EventHandler(menuExit_Click);
        }// End CreateMyMainMenu
        //Show frmChildForm
        private void menuOpen_Click(object sender, EventArgs e)
        {
            frmChildForm childForm = new frmChildForm();
            childForm.Text = $"ChildForm {counter++:D2}";
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
