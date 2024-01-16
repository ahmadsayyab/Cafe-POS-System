using BisleriumCafePOSSystem.Core.Model;
using BisleriumCafePOSSystem.Core.Services;
using BisleriumCafePOSSystem.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafePOSSystem
{
    public partial class frmMain : Form
    {
        private readonly UserService userService;
        public frmMain()
        {
            InitializeComponent();
            userService = new UserService();
        }

        string email_pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        string pass_pattern = @"(?=^.{8,}$)((?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        //Ensure valid string inputs
        private void EnsureValidStringInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 32)
            {
                // Allow space (ASCII code 32)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        //Ensure valid numeric inputs
        private void EnsureValidNumericInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
           else if (ch == 43)
            {
                // Allow plus sign (ASCII code 43)
                e.Handled = false;
            }
           
            else
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, email_pattern) == false)
            {
                txtEmail.Focus();
                errEmail.SetError(this.txtEmail, "Enter valid email!!");
            }
            else
            {
                errEmail.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, pass_pattern) == false)
            {
                txtPassword.Focus();
                errPassword.SetError(this.txtPassword, "Enter strong password, Uppercase, lowercase, numbers & special char combination!!");
            }
            else
            {
                errPassword.Clear();
            }
        }

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

        //reset textboxes
        private void ResetControls()
        {
            txtFullName.Clear();
            cmbGender.SelectedItem = null;
            txtRole.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            
        }

        //Add user
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == string.Empty || cmbGender.SelectedItem == null
                || txtRole.Text == string.Empty || txtEmail.Text == string.Empty
                || txtPhoneNumber.Text == string.Empty || txtPassword.Text == string.Empty
                || Regex.IsMatch(txtPassword.Text, pass_pattern) == false)
            {
                MessageBox.Show("Please ensure all fields are filled correctly and \nthe password meets the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {

                    User newUser = new User
                    {
                        FullName = txtFullName.Text.Trim(),
                        Gender = cmbGender.SelectedItem.ToString(),
                        Role = txtRole.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        PhoneNumber = txtPhoneNumber.Text.Trim(),
                        Password = txtPassword.Text.Trim()
                    };


                    userService.AddUser(newUser);
                    frmHome home = new frmHome();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void llbAlreadyRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
