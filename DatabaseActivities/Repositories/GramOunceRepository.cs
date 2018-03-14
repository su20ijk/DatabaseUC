using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class GramOunceRepository
    {
        private ApplicationDbContext dbContext;

        public GramOunceRepository()
        {
            dbContext = new ApplicationDbContext();  
        }

        public List<GramToOunce> GetAllGramToOunce()
        {
            return dbContext.GramToOunce.ToList();
        }

        public void AddUnitConversion(GramToOunce toAdd)
        {
            dbContext.GramToOunce.Add(toAdd);
            dbContext.SaveChanges();
        }
    }
}