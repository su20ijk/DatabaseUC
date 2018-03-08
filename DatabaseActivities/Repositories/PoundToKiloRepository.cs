using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class PoundToKiloRepository
    {
        private ApplicationDbContext context;

        public PoundToKiloRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<PoundToKilo> GetAllConversions()
        {
            return context.PoundsToKilos.ToList();
        }

        public void AddUnitConversion(PoundToKilo toAdd)
        {
            context.PoundsToKilos.Add(toAdd);
            context.SaveChanges();
        }

        public void DeleteUnitConversion(int Id)
        {
            context.PoundsToKilos.Remove(context.PoundsToKilos.Find(Id));
            context.SaveChanges();
        }

        public void SaveEdits(PoundToKilo toSave)
        {
            context.Entry(toSave).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}