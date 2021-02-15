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
    public partial class AddUserForm : Form
    {
        private readonly CarRentalEntities _db = new CarRentalEntities();
        List<Role> _roles;

        public AddUserForm()
        {
            InitializeComponent();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.isActive = false;
            user.Username = txt_Username.Text.Trim();
            user.Password = Utils.HashPassword(txt_Password.Text);
            _db.Users.Add(user);
            _db.SaveChanges();
            
            

            var newUser = _db.Users.FirstOrDefault(x => x.Username == user.Username);

            UserRole userRole = new UserRole();
            userRole.UserId = newUser.Id;
            userRole.RoleId = (int)cmb_Role.SelectedValue;
            _db.UserRoles.Add(userRole);
            _db.SaveChanges();

            MessageBox.Show($"New user {user.Username} added.\nPassword: {txt_Password.Text}");
            txt_Username.Clear();
            txt_Password.Clear();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            _roles = _db.Roles.ToList();
            cmb_Role.DataSource = _roles;
            cmb_Role.DisplayMember = "Name";
            cmb_Role.ValueMember = "Id";
        }
    }
}
