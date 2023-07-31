using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Repositorys.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinalProject.Repositorys.Controls
{
    internal class PostDbAsync
    {
        public async Task<Post> GetPostByIdAsync(int id)
        {
            Post? MyPost = null;
            try
            {
                using var context = new EnvEntities();
                MyPost = await context.Posts.FirstOrDefaultAsync(u => u.PostId == id);
            }
            catch (ArgumentNullException nlex) { throw new Exception(nlex.Message); }
            catch (InvalidOperationException opex) { throw new Exception(opex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyPost;
        }

        public async Task AddPostAsync(Post Post)
        {
            try
            {
                Post MyPost = await GetPostByIdAsync(Post.PostId);   
                if (MyPost == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Posts.AddAsync(Post);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException dbex) { throw new Exception(dbex.Message); }
                    catch (DbUpdateException upex) { throw new Exception(upex.Message); }
                    catch (Exception ex) { throw new Exception(ex.Message); }
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

        public async Task UpdatePostAsync(Post Post)
        {
            try
            {
                Post MyPost = await GetPostByIdAsync(Post.PostId);
                if (MyPost != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Posts.Update(Post);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException dbex) { throw new Exception(dbex.Message); }
                    catch (DbUpdateException upex) { throw new Exception(upex.Message); }
                    catch (Exception ex) { throw new Exception(ex.Message); }
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

        public async Task DeletePostAsync(Post Post)
        {
            try
            {
                Post MyPost = await GetPostByIdAsync(Post.PostId);
                if (MyPost != null)
                {
                    using var context = new EnvEntities();
                    context.Posts.Remove(Post);
                    await context.SaveChangesAsync();
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

        public async Task<List<Post>> GetPostListAsync()
        {
            List<Post> PostList = new List<Post>();

            try
            {
                using var context = new EnvEntities();
                PostList = await context.Posts.ToListAsync();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return PostList;
        }

        public async Task<List<Post>> GetPostListByUserIdAsync(int userid)
        {
            List<Post> PostList = new List<Post>();

            try
            {
                using var context = new EnvEntities();
                PostList = await context.Posts.Where(p => p.UserId == userid).ToListAsync();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return PostList;
        }

        public async Task<List<Post>> GetPostListByKeywordAsync(string keyword)
        {
            List<Post> PostList = new List<Post>();

            try
            {
                using var context = new EnvEntities();
                PostList = await context.Posts.Where(p => p.Caption.Contains(keyword)).ToListAsync();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return PostList;
        }
    }
}
