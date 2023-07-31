using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApp.Repositorys.Models;

namespace InstagramApp.Repositorys.Controls
{
    internal class UserDb
    {
        public User GetUserById(int id)
        {
            User? MyUser = null;
            try
            {
                using var context = new EnvEntities();
                MyUser = context.Users.SingleOrDefault(u => u.UserId == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyUser;
        }

        public User GetUserByUserName(string username)
        {
            User? MyUser = null;
            try
            {
                using var context = new EnvEntities();
                MyUser = context.Users.SingleOrDefault(u => u.UserName == username);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyUser;
        }

        public void AddUser(User user)
        {
            try
            {
                User MyUser = GetUserById(user.UserId);
                if (MyUser == null) {
                    using var context = new EnvEntities();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User already exists on Instagram.");               
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                User MyUser = GetUserById(user.UserId);
                if (MyUser != null)
                {
                    using var context = new EnvEntities();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                User MyUser = GetUserById(user.UserId);
                if (MyUser != null)
                {
                    using var context = new EnvEntities();
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<User> GetUserList()
        {
            List<User> userList = new List<User>();

            try
            {
                using var context = new EnvEntities();
                userList = context.Users.ToList();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }

            return userList;
        }
    }
}
