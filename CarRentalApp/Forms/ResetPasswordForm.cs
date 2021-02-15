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
    public partial class ResetPasswordForm : Form
    {
        CarRentalEntities _db = new CarRentalEntities();
        User _user;
        string _newPassword;
        public ResetPasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            _newPassword = txt_newPass.Text;
            _user.Password = Utils.HashPassword(_newPassword);
            MessageBox.Show($"User: {_user.Username}\n Password reset to: {_newPassword}");
            this.DialogResult = DialogResult.OK;
        }
    }
}
