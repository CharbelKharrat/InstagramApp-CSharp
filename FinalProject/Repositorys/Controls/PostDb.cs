using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Repositorys.Models;

namespace FinalProject.Repositorys.Controls
{
    internal class PostDb
    {
        public Post GetPostById(int id)
        {
            Post? MyPost = null;
            try
            {
                using var context = new EnvEntities();
                MyPost = context.Posts.SingleOrDefault(u => u.PostId == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyPost;
        }

        public void AddPost(Post Post)
        {
            try
            {
                Post MyPost = GetPostById(Post.PostId);
                if (MyPost == null)
                {
                    using var context = new EnvEntities();
                    context.Posts.Add(Post);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Post already exists on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePost(Post Post)
        {
            try
            {
                Post MyPost = GetPostById(Post.PostId);
                if (MyPost != null)
                {
                    using var context = new EnvEntities();
                    context.Posts.Update(Post);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Post does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletePost(Post Post)
        {
            try
            {
                Post MyPost = GetPostById(Post.PostId);
                if (MyPost != null)
                {
                    using var context = new EnvEntities();
                    context.Posts.Remove(Post);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Post does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Post> GetPostList()
        {
            List<Post> PostList = new List<Post>();

            try
            {
                using var context = new EnvEntities();
                PostList = context.Posts.ToList();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return PostList;
        }
    }
}
