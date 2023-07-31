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
using InstagramApp.Repositorys.Controls;
using InstagramApp.Repositorys.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;

namespace InstagramApp
{
    public partial class Create_New_Account_Form : Form
    {
        public Create_New_Account_Form()
        {
            InitializeComponent();
        }

        private async void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserDbAsync userDb = new UserDbAsync();
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByUserNameAsync(usernameTextBox.Text));
            if (myUser != null)
            {
                usernameValidationLabel.Text = "Username already exists. Choose another one.";
            }
            else { usernameValidationLabel.Text = ""; }
        }

        private void Create_New_Account_Form_Load(object sender, EventArgs e)
        {
            usernameValidationLabel.Text = "";
            passValidationLabel.Text = "";
            emailValidationLabel.Text = "";
        }

        private async void createAccBtn_Click(object sender, EventArgs e)
        {

            User myUser = new User();
            myUser.UserEmail = emailTextBox.Text;
            myUser.Password = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
            // myUser.Password = passwordTextBox.Text;
            myUser.UserName = usernameTextBox.Text;
            myUser.Verified = false;

            UserDbAsync userDb = new UserDbAsync();
            await userDb.AddUserAsync(myUser);

            MessageBox.Show("Account successfully created!");

            Form loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else { passwordTextBox.UseSystemPasswordChar = true; }

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            passValidationLabel.Text = "";

            bool hasMinlength = false, hasUpperLetter = false, hasLowerLetter = false, hasNumber = false, hasSpecialChar = false;

            // Check for minimum length
            if (password.Length >= 8)
            {
                hasMinlength = true;
            }

            // Check for at least one uppercase letter
            if (password.Any(char.IsUpper))
            {
                hasUpperLetter = true;
            }

            // Check for at least one lowercase letter
            if (password.Any(char.IsLower))
            {
                hasLowerLetter = true;
            }

            // Check for at least one number
            if (password.Any(char.IsDigit))
            {
                hasNumber = true;
            }

            // Check for at least one special character
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            if (password.Any(password => specialCharacters.Contains(password)))
            {
                hasSpecialChar = true;
            }

            if (!hasMinlength || !hasUpperLetter || !hasLowerLetter || !hasNumber || !hasSpecialChar)
            {
                passValidationLabel.Text = "Your password should ";
            }

            if (!hasMinlength)
            {
                passValidationLabel.Text += "be at least 8 characters ";
            }

            if (!hasUpperLetter || !hasLowerLetter || !hasNumber || !hasSpecialChar)
            {
                passValidationLabel.Text += "contain at least ";
            }

            if (!hasUpperLetter) { passValidationLabel.Text += "1 upper letter "; }
            if (!hasLowerLetter) { passValidationLabel.Text += "1 lower letter "; }
            if (!hasNumber) { passValidationLabel.Text += "1 number "; }
            if (!hasSpecialChar) { passValidationLabel.Text += "1 special character "; }
        }

        private async void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            UserDbAsync userDb = new UserDbAsync();
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByEmailAsync(emailTextBox.Text));
            if (myUser != null)
            {
                emailValidationLabel.Text = "Email already in use. Try logging in instead. ";
            }
            else { emailValidationLabel.Text = ""; }

            if (!Regex.IsMatch(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                emailValidationLabel.Text += "Please enter a valid email address (name@website.com). ";
            }
        }
    }
}
