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
using Microsoft.Identity.Client;

namespace InstagramApp
{
    public partial class Profile_Form : Form
    {
        string username;
        public Profile_Form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private async void changeUsernameBtn_Click(object sender, EventArgs e)
        {
            UserDbAsync userdb = new UserDbAsync();
            User MyUser = new User();

            MyUser = await userdb.GetUserByUserNameAsync(username);

            MyUser.UserName = usernameTxtBox.Text.Trim();
            username = usernameTxtBox.Text.Trim();

            await userdb.UpdateUserAsync(MyUser);

            MessageBox.Show("Username updated successfully.");
        }

        private async void changeEmailBtn_Click(object sender, EventArgs e)
        {
            UserDbAsync userdb = new UserDbAsync();
            User MyUser = new User();

            MyUser = await userdb.GetUserByUserNameAsync(username);

            MyUser.UserEmail = emailTxtBox.Text.Trim();

            await userdb.UpdateUserAsync(MyUser);

            MessageBox.Show("Email updated successfully.");
        }

        private async void Profile_Form_Load(object sender, EventArgs e)
        {
            usernameValidationLabel.Text = "";
            emailValidationLabel.Text = "";

            // Updating the username text box
            usernameTxtBox.Text = username;

            User MyUser = new User();
            UserDbAsync userdb = new UserDbAsync();

            MyUser = await userdb.GetUserByUserNameAsync(username);

            // Updating the email text box
            emailTxtBox.Text = MyUser.UserEmail;

            // Update the posts data grid
            LoadPostDataAsync();

            this.postgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.postgv.SelectionChanged += new EventHandler(postgv_SelectionChanged);

        }

        private async void LoadPostDataAsync()
        {
            User MyUser = new User();
            UserDbAsync userdb = new UserDbAsync();
            MyUser = await userdb.GetUserByUserNameAsync(username);

            this.postgv.AutoGenerateColumns = true;
            PostDbAsync postdb = new PostDbAsync();
            List<Post> userposts = await postdb.GetPostListByUserIdAsync(MyUser.UserId);
            userposts = userposts.OrderByDescending(p => p.Timestamp).ToList();
            this.postgv.DataSource = userposts;

            this.postgv.Columns["PostId"].ReadOnly = true;
            this.postgv.Columns["UserId"].ReadOnly = true;
            this.postgv.Columns["Url"].ReadOnly = true;
            this.postgv.Columns["Timestamp"].ReadOnly = true;
        }

        private void postgv_SelectionChanged(object sender, EventArgs e)
        {
            Post post = (Post)this.postgv.CurrentRow.DataBoundItem;

            imageurlTxtBox.Text = post.ImageUrl;
            captionTextBox.Text = post.Caption;
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            Post post = (Post)this.postgv.CurrentRow.DataBoundItem;

            post.ImageUrl = imageurlTxtBox.Text;
            post.Caption = captionTextBox.Text;

            PostDbAsync postdb = new PostDbAsync();
            await Task.Run(() => postdb.UpdatePostAsync(post));

            MessageBox.Show("Post updated successfully.");

            LoadPostDataAsync();
        }

        private async void CreatePostBtn_Click(object sender, EventArgs e)
        {
            Post newPost = new Post();
            PostDbAsync postdb = new PostDbAsync();
            User MyUser = new User();
            UserDbAsync userdb = new UserDbAsync();

            MyUser = await userdb.GetUserByUserNameAsync(username);
            List<Post> userposts = await postdb.GetPostListByUserIdAsync(MyUser.UserId);
            if (!userposts.Any()) { newPost.PostId = MyUser.UserId * 10 + 1; }
            else { newPost.PostId = userposts.AsParallel().Max(p => p.PostId) + 1; }

            newPost.UserId = MyUser.UserId;
            newPost.Timestamp = DateTime.Now;
            newPost.Caption = captionTextBox.Text;
            newPost.ImageUrl = imageurlTxtBox.Text;

            await postdb.AddPostAsync(newPost);

            MessageBox.Show("Post Created Successfully.");

            LoadPostDataAsync();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            Post post = (Post)this.postgv.CurrentRow.DataBoundItem;

            PostDbAsync postdb = new PostDbAsync();
            await Task.Run(() => postdb.DeletePostAsync(post));

            MessageBox.Show("Post deleted successfully.");

            LoadPostDataAsync();
        }

        private void Profile_Form_Leave(object sender, EventArgs e)
        {

        }

        private void backtohomeBtn_Click(object sender, EventArgs e)
        {
            Form igfeedform = new Instagram_Feed_Form(username);
            this.Hide();
            igfeedform.ShowDialog();
            this.Close();
        }

        private async void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {
            UserDbAsync userDb = new UserDbAsync();
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByUserNameAsync(usernameTxtBox.Text));
            if (myUser != null && usernameTxtBox.Text != username)
            {
                usernameValidationLabel.Text = "Username already exists. Choose another one.";
            }
            else { usernameValidationLabel.Text = ""; }
        }

        private async void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            UserDbAsync userDb = new UserDbAsync();
            
            // MyUser is the current user
            User myUser = new User();
            myUser = await Task.Run(() => userDb.GetUserByUserNameAsync(username));

            // EmailUser is another user using the same email address
            User EmailUser = new User();
            EmailUser = await Task.Run(() => userDb.GetUserByEmailAsync(emailTxtBox.Text));

            if (EmailUser != null && emailTxtBox.Text != myUser.UserEmail)
            {
                emailValidationLabel.Text = "Email already in use in another account. ";
            }
            else { emailValidationLabel.Text = ""; }

            if (!Regex.IsMatch(emailTxtBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                emailValidationLabel.Text += "Please enter a valid email address (name@website.com). ";
            }
        }
    }
}
