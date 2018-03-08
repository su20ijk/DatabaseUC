using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repository
{
    public class BaseRepository
    {
        private ApplicationDbContext context;
        public BaseRepository()
        {
            context = new ApplicationDbContext();
        }
        public List<Base> GetAllBases()
        {
            return context.Base.ToList();
        }
        public void AddBase(Base toAdd)
        {
            context.Base.Add(toAdd);
            context.SaveChanges();
        }
        public Base GetBaseById(int id)
        {
            return context.Base.Find(id);
        }
        public void SaveEdit(Base ToSave)
        {
            context.Entry(ToSave).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteBase(Base toDelete)
        {
            context.Base.Remove(toDelete);
            context.SaveChanges();
        }
    }
}