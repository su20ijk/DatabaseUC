using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repository
{
    public class MeterstoFeetRepo
    {
        private ApplicationDbContext context;
        public MeterstoFeetRepo()
        {
            context = new ApplicationDbContext();
        }

        public List<MeterToFoot> GetAllConversions()
        {
            return context.MeterstoFeet.ToList();
        }

        public void CreateConversion(MeterToFoot toAdd)
        {
            context.MeterstoFeet.Add(toAdd);
            context.SaveChanges();
        }

        public void DeleteConversion(int Id)
        {
            context.MeterstoFeet.Remove(context.MeterstoFeet.Find(Id));
            context.SaveChanges();
        }

        public void SaveEdit(MeterToFoot toSave)
        {
            context.Entry(toSave).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

