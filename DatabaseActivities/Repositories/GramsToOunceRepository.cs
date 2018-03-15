using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class GramsToOunceRepository
    {
        private ApplicationDbContext dbContext;

        public GramsToOunceRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public List<GramToOunce> GetAllConversions()
        {
            return dbContext.GramToOunceBD.ToList();
        }

        public void AddConversion(GramToOunce toAdd)
        {
            dbContext.GramToOunceBD.Add(toAdd);
            dbContext.SaveChanges();
        }
    }
}