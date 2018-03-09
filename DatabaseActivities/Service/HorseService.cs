using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class HorseService
    {
        private HorseRepository repository;

        public HorseService()
        {
            repository = new HorseRepository();
        }

        public List<HorsetoBlock> GetAllConversions()
        {
            return repository.GetAllConversions();
        }

        public void AddConversion(double Horses)
        {
            double Blocks = Horses * 0.33333333333333;
            HorsetoBlock temp = new HorsetoBlock();
            temp.Horses = Horses;
            temp.Blocks = Blocks;
            repository.AddUnitConversion(temp);
        }

        public void DeleteConversion(int Id)
        {
            repository.DeleteUnitConversion(Id);
        }

        public void SaveEdits(HorsetoBlock toSave)
        {
            repository.SaveEdits(toSave);
        }
    }
}