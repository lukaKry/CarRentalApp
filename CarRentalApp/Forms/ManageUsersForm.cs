using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.Forms
{
    public partial class ManageUsersForm : Form
    {
        private readonly CarRentalEntities _db = new CarRentalEntities();
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.MdiParent = this.MdiParent;
            auf.WindowState = FormWindowState.Maximized;
            auf.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                //get the record object from selection
                var id = (int)dgv_UserList.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(a => a.Id == id);
                
                ResetPasswordForm rpf = new ResetPasswordForm(user);

                var result = rpf.ShowDialog();
                _db.SaveChanges();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Select at least one row.");
            }
        }

        private void btn_Deactive_Click(object sender, EventArgs e)
        {
            try
            {
                //get the record object from selection
                var id = (int)dgv_UserList.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(a => a.Id == id);

                if (user.isActive.HasValue)
                    user.isActive = (user.isActive == true) ? false : true;
                else user.isActive = true;

                    _db.SaveChanges();

                MessageBox.Show($"Activness of User: {user.Username} has been set to {user.isActive}.");
            }
            catch (Exception)
            {
                MessageBox.Show("Select at least one row.");
            }

        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            var userList = _db.Users.Select(x => new { x.Id, x.Username, x.isActive, x.UserRoles.FirstOrDefault().Role.Name }).ToList();
            dgv_UserList.DataSource = userList;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            var userList = _db.Users.Select(x => new { x.Id, x.Username, x.isActive, x.UserRoles.FirstOrDefault().Role.Name }).ToList();
            dgv_UserList.DataSource = userList;
        }
    }
}
