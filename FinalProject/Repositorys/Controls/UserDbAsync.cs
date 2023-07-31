using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Repositorys.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositorys.Controls
{
    internal class UserDbAsync
    {
        public async Task<User> GetUserByIdAsync(int id)
        {
            User? MyUser = null;
            try
            {
                using var context = new EnvEntities();
                MyUser = await context.Users.FirstOrDefaultAsync(u => u.UserId == id);
            }
            catch (ArgumentNullException nlex) { throw new Exception(nlex.Message); }
            catch (InvalidOperationException opex) { throw new Exception(opex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyUser;
        }

        public async Task<User> GetUserByUserNameAsync(string username)
        {
            User? MyUser = null;
            try
            {
                using var context = new EnvEntities();
                MyUser = await context.Users.SingleOrDefaultAsync(u => u.UserName == username);
            }
            catch (ArgumentNullException nlex) { throw new Exception(nlex.Message); }
            catch (InvalidOperationException opex) { throw new Exception(opex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyUser;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            User? MyUser = null;
            try
            {
                using var context = new EnvEntities();
                MyUser = await context.Users.SingleOrDefaultAsync(u => u.UserEmail == email);
            }
            catch (ArgumentNullException nlex) { throw new Exception(nlex.Message); }
            catch (InvalidOperationException opex) { throw new Exception(opex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyUser;
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                User MyUser = await GetUserByUserNameAsync(user.UserName);
                if (MyUser == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Users.AddAsync(user);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException dbex) { throw new Exception(dbex.Message); }
                    catch (DbUpdateException upex) { throw new Exception(upex.Message); }
                    catch (Exception ex) { throw new Exception(ex.Message); }
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

        public async Task UpdateUserAsync(User user)
        {
            try
            {
                User MyUser = await GetUserByUserNameAsync(user.UserName);
                if (MyUser != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Users.Update(user);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException dbex) { throw new Exception(dbex.Message); }
                    catch (DbUpdateException upex) { throw new Exception(upex.Message); }
                    catch (Exception ex) { throw new Exception(ex.Message); }
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

        public async Task DeleteUserAsync(User user)
        {
            try
            {
                User MyUser = await GetUserByUserNameAsync(user.UserName);
                if (MyUser != null)
                {
                    using var context = new EnvEntities();
                    context.Users.Remove(user);
                    await context.SaveChangesAsync();
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

        public async Task<List<User>> GetUserListAsync()
        {
            List<User> userList = new List<User>();

            try
            {
                using var context = new EnvEntities();
                userList = await context.Users.ToListAsync();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return userList;
        }

    }
}
