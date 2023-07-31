using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Repositorys.Models;

namespace FinalProject.Repositorys.Controls
{
    internal class ReelDb
    {
        public Reel GetReelById(int id)
        {
            Reel? MyReel = null;
            try
            {
                using var context = new EnvEntities();
                MyReel = context.Reels.SingleOrDefault(u => u.ReelId == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return MyReel;
        }

        public void AddReel(Reel Reel)
        {
            try
            {
                Reel MyReel = GetReelById(Reel.ReelId);
                if (MyReel == null)
                {
                    using var context = new EnvEntities();
                    context.Reels.Add(Reel);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Reel already exists on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateReel(Reel Reel)
        {
            try
            {
                Reel MyReel = GetReelById(Reel.ReelId);
                if (MyReel != null)
                {
                    using var context = new EnvEntities();
                    context.Reels.Update(Reel);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Reel does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteReel(Reel Reel)
        {
            try
            {
                Reel MyReel = GetReelById(Reel.ReelId);
                if (MyReel != null)
                {
                    using var context = new EnvEntities();
                    context.Reels.Remove(Reel);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Reel does not exist on Instagram.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Reel> GetReelList()
        {
            List<Reel> ReelList = new List<Reel>();

            try
            {
                using var context = new EnvEntities();
                ReelList = context.Reels.ToList();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return ReelList;
        }
    }
}
