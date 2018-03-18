using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class GramsToOunceService
    {
        private GramsToOunceRepository repo;

        public GramsToOunceService()
        {
            repo = new GramsToOunceRepository();
        }

        public List<GramToOunce> GetAllConversions()
        {
            return repo.GetAllConversions();
        }

        public void AddConversion(double inGrams)
        {
            GramToOunce temp = new GramToOunce();
            temp.Ounce = (inGrams * .035274);
            temp.Gram = inGrams;
            repo.AddConversion(temp);
        }

		public void DeleteConversion(int Id)
		{
			repo.DeleteUnitConversion(Id);
		}

		public void SaveEdits(int IDX, double Grams)
		{
			repo.SaveEdits(IDX, Grams);
		}
	}
}