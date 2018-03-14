using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class GramOunceService
    {
        private GramOunceRepository repository;

        public GramOunceService()
        {
            repository = new GramOunceRepository();
        }

        public List<GramToOunce> GetAllConversions()
        {
            return repository.GetAllGramToOunce();
        }

        public void AddConversion(double Grams)
        {
            double Ounce = Grams * 0.035274;
            GramToOunce temp = new GramToOunce();
            temp.Ounes = Ounce;
            temp.Grams = Grams;
            repository.AddUnitConversion(temp);
        }
    }

}