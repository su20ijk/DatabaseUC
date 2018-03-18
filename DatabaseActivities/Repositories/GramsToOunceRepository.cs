using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

		public void DeleteUnitConversion(int Id)
		{
			dbContext.GramToOunceBD.Remove(dbContext.GramToOunceBD.Find(Id));
			dbContext.SaveChanges();
		}
		public void SaveEdits(int Id, double Grams)
		{
			GramToOunce toEdit = dbContext.GramToOunceBD.Find(Id);
			toEdit.Ounce = (Grams * .035274);
			toEdit.Gram = Grams;
			dbContext.SaveChanges();
		}
	}
}