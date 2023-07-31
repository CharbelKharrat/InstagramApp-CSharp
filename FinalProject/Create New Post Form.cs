using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using FinalProject.Repositorys.Controls;
using FinalProject.Repositorys.Models;

namespace FinalProject
{
    public partial class Create_New_Post_Form : Form
    {
        string username;
        public Create_New_Post_Form(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void Create_New_Post_Form_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Post Now";
        }

        private async void CreatePostBtn_Click(object sender, EventArgs e)
        {
            Post newPost = new Post();
            PostDbAsync postdb = new PostDbAsync();
            User MyUser = new User();
            UserDbAsync userdb = new UserDbAsync();
            MyUser = await userdb.GetUserByUserNameAsync(username);
            List<Post> userposts = await postdb.GetPostListByUserIdAsync(MyUser.UserId);


            // Assigning post data (PostId, UserId, Caption, ImageUrl)
            if (!userposts.Any()) { newPost.PostId = MyUser.UserId * 10 + 1; }
            else { newPost.PostId = userposts.AsParallel().Max(p => p.PostId) + 1; }

            newPost.UserId = MyUser.UserId;
            newPost.Caption = captionTextBox.Text;
            newPost.ImageUrl = imageurlTextBox.Text;

            // Assigning post timestamp
            if (comboBox1.SelectedItem.ToString() == "Post Now") { newPost.Timestamp = DateTime.Now; }
            else { newPost.Timestamp = dateTimePicker1.Value; }

            // Adding Post to Db
            await postdb.AddPostAsync(newPost);

            MessageBox.Show("Post Created Successfully.");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Schedule")
            {
                dateLabel.Visible = true;
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateLabel.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }

        private void backtohomeBtn_Click(object sender, EventArgs e)
        {
            Form igfeedform = new Instagram_Feed_Form(username);
            this.Hide();
            igfeedform.ShowDialog();
            this.Close();
        }
    }
}
