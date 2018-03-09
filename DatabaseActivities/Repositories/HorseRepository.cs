using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class HorseRepository
    {
        private ApplicationDbContext context;

        public HorseRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<HorsetoBlock> GetAllConversions()
        {
            return context.HorsestoBlocks.ToList();
        }

        public void AddUnitConversion(HorsetoBlock toAdd)
        {
            context.HorsestoBlocks.Add(toAdd);
            context.SaveChanges();
        }

        public void DeleteUnitConversion(int Id)
        {
            context.HorsestoBlocks.Remove(context.HorsestoBlocks.Find(Id));
            context.SaveChanges();
        }

        public void SaveEdits(HorsetoBlock toSave)
        {
            context.Entry(toSave).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}