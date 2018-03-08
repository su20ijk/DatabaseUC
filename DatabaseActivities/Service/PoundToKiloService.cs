using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class PoundToKiloService
    {
        private PoundToKiloRepository repository;

        public PoundToKiloService()
        {
            repository = new PoundToKiloRepository();
        }

        public List<PoundToKilo> GetAllConversions()
        {
            return repository.GetAllConversions();
        }

        public void AddConversion(double Pounds)
        {
            double Kilograms = Pounds * 0.453592;
            PoundToKilo temp = new PoundToKilo();
            temp.Pounds = Pounds;
            temp.Kilograms = Kilograms;
            repository.AddUnitConversion(temp);
        }

        public void DeleteConversion(int Id)
        {
            repository.DeleteUnitConversion(Id);
        }

        public void SaveEdits(PoundToKilo toSave)
        {
            repository.SaveEdits(toSave);
        }
    }
}