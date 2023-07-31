using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Repositorys.Controls;
using FinalProject.Repositorys.Models;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void showPassword_checked(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newAccountForm = new Create_New_Account_Form();
            this.Hide();
            newAccountForm.ShowDialog();
            this.Close();
        }

        private async void loginBtn_click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;

            UserDbAsync userDb = new UserDbAsync();
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByUserNameAsync(usernameTextBox.Text));

            string hashedPassword = myUser.Password;

            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
            {
                Form igfeedForm = new Instagram_Feed_Form(myUser.UserName);
                this.Hide();
                igfeedForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password. Try Again.");
            }
        }

        private async void usernameText_changed(object sender, EventArgs e)
        {
            UserDbAsync userDb = new UserDbAsync();
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByUserNameAsync(usernameTextBox.Text));
            if (myUser == null)
            {
                usernameValidationLabel.Text = "Username does not exist.";
            }
            else { usernameValidationLabel.Text = ""; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameValidationLabel.Text = "";
        }

        private void backtohomeBtn_Click(object sender, EventArgs e)
        {
            Form igfeedform = new Instagram_Feed_Form("");
            this.Hide();
            igfeedform.ShowDialog();
            this.Close();
        }
    }
}
