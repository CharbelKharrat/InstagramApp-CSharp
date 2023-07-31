using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApp.Repositorys.Controls;
using InstagramApp.Repositorys.Models;

namespace InstagramApp
{
    public partial class Instagram_Feed_Form : Form
    {
        public string username;
        public Instagram_Feed_Form(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username == "") // i.e. The user is not logged in
            {
                Form loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                loginBtn.Text = "Login";
                statusLabel.Text = "Not logged in.";
                username = "";
                ProfileBtn.Visible = false;
            }
        }

        private async void Instagram_Feed_Form_Load(object sender, EventArgs e)
        {
            if (username == "")
            {
                loginBtn.Text = "Login";
                statusLabel.Text = "Not logged in.";
            }
            else
            {
                loginBtn.Text = "Log out";
                statusLabel.Text = "Logged in (" + username + ")";
            }

            LoadPostDataAsync();
        }

        private void CreatePostBtn_Click(object sender, EventArgs e)
        {
            if (username == "")
            {
                MessageBox.Show("Please login to create a new post.");
            }
            else
            {
                Form newPostForm = new Create_New_Post_Form(username);
                newPostForm.ShowDialog();
            }
        }

        private async void postgv_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private async void Instagram_Feed_Form_Activated(object sender, EventArgs e)
        {
            LoadPostDataAsync();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Form profileForm = new Profile_Form(username);
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private async void LoadPostDataAsync()
        {
            this.postgv.AutoGenerateColumns = true;

            // Getting posts list from the database + filtering them by
            // keyword (if any text is available in the search text box)
            PostDbAsync postdb = new PostDbAsync();
            List<Post> posts = new List<Post>();
            if (searchTextBox.Text == "")
            {
                posts = await Task.Run(() => postdb.GetPostListAsync());
            }
            else { posts = await Task.Run(() => postdb.GetPostListByKeywordAsync(searchTextBox.Text)); }
            
            // Getting users list from database
            UserDbAsync userdb = new UserDbAsync();
            List<User> users = new List<User>();
            users = await Task.Run(() => userdb.GetUserListAsync());

            // Joining the data tables to show the username on the data grid
            List<PostUserViewModel> postList = new List<PostUserViewModel>();
            postList = (from p in posts
                        join u in users on p.UserId equals u.UserId
                        select new PostUserViewModel
                        {
                            PostId = p.PostId,
                            Caption = p.Caption,
                            ImageUrl = p.ImageUrl,
                            Url = p.Url,
                            Likes = p.LikeCount,
                            Date = p.Timestamp,
                            Username = u.UserName
                        }).ToList();

            postList = postList.AsParallel().OrderByDescending(p => p.Date).ToList();

            this.postgv.DataSource = postList;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadPostDataAsync();
        }
    }
}
