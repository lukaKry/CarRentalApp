using CarRentalApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private LoginForm _loginForm;
        public User _user;
        public string _userRoleName;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(LoginForm loginForm, User user)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _user = user;
            _userRoleName = user.UserRoles.FirstOrDefault().Role.ShortName;
                
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(x => x.Name == "AddRentalRecord");
            if (!isOpen)
            {
                AddRentalRecord arr = new AddRentalRecord();
                arr.MdiParent = this;
                arr.WindowState = FormWindowState.Maximized;
                arr.Show();
            }
                
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicleListing mvl = new ManageVehicleListing();
            mvl.MdiParent = this;
            mvl.WindowState = FormWindowState.Maximized;
            mvl.Show();
        }

        private void editRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRentalRecodrs mrr = new ManageRentalRecodrs();
            mrr.MdiParent = this;
            mrr.WindowState = FormWindowState.Maximized;
            mrr.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(x => x.Name == "ManageUsersForm");
            if (!isOpen)
            {
                ManageUsersForm muf = new ManageUsersForm();
                muf.MdiParent = this;
                muf.WindowState = FormWindowState.Maximized;
                muf.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_userRoleName != "admin")
                manageUsersToolStripMenuItem.Visible = false;
            toolStripStatusLabel1.Text = $"Logged in as: {_user.Username}";
        }
    }
}
