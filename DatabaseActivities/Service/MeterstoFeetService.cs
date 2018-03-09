using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class MeterstoFeetService
    {
        private MeterstoFeetRepo repository;
        public MeterstoFeetService()
        {
            repository = new MeterstoFeetRepo();
        }

        public List<MeterstoFeet> GetAllConversions()
        {
            return repository.GetAllConversions();
        }

        public void CreateConversions(double Meters)
        {
            Double Feet = Meters * 3.21;
            MeterstoFeet x = new MeterstoFeet();
            x.Meters = Meters;
            x.Feet = Feet;
            repository.CreateConversion(x);
        }
        public void DeleteConversion(int Id)
        {
            repository.DeleteConversion(Id);
        }
        public void SaveEdits(MeterstoFeet toSave)
        {
            repository.SaveEdit(toSave);
        }
    }
}