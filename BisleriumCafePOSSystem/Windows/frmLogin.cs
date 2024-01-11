using BisleriumCafePOSSystem.Core.Model;
using BisleriumCafePOSSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmLogin : Form
    {
        private readonly UserService userService;
        public frmLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void llbNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }


        //Authenticate user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill both the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var credentials = new Credentials
                {
                    Email = txtEmail.Text.Trim(),
                    Password =  txtPassword.Text.Trim()
                };
                User user = userService.ValidateLogin(credentials);

                if (user != null)
                {
                    frmHome home = new frmHome();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Invalid email or password.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //show or hide password characters
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkShowPassword.Checked;
            switch (check)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;

                    break;
                default:
                    txtPassword.UseSystemPasswordChar = true;

                    break;
            }
        }
    }
}
