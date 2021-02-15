using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.Forms
{
    public partial class LoginForm : Form
    {
        private CarRentalEntities _db;
        
        public LoginForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                //username: admin - password: admin
                //username: user - password:  password@123
                //Default Name - password

                string hashedPassword = Utils.HashPassword(txt_password.Text);

                var user = _db.Users.FirstOrDefault(q => q.Username == txt_username.Text);

                if (user.Username == txt_username.Text && user.Password == hashedPassword && user.isActive == true)
                {
                    
                    MainWindow mn = new MainWindow(this, user);
                    mn.StartPosition = FormStartPosition.CenterScreen;
                    mn.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid data or inactive user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}
