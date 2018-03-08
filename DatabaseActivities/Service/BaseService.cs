using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class BaseService
    {
        private BaseRepository repository;
        public BaseService()
        {
            repository = new BaseRepository();
        }
        public List<Base> GetAllBase()
        {
            return repository.GetAllBases();
        }
        public Base GetBaseById(int id)
        {
            return repository.GetBaseById(id);
        }
        public void AddBase(Base toAdd)
        {
            repository.AddBase(toAdd);
        }
        public void DeleteBase(Base toDelete)
        {
            repository.DeleteBase(toDelete);
        }
        internal void SaveEdits(Base toSave)
        {
            repository.SaveEdit(toSave);
        }
        public int CalculateActualNumber(int StartBase, int StartNumber)
        {
            List<int> numbers = new List<int>();
            string StartNumberToString = "" + StartNumber;
            int digit = StartNumberToString.Length;
            int CopyOfStartNumber = StartNumber;
            int CopyOfDigit = digit;
            for (int i = 0; i < digit - 1; i++)
            {
                numbers.Add(CopyOfStartNumber / ((int)(Math.Pow(10, (CopyOfDigit - 1)))));
                CopyOfStartNumber = CopyOfStartNumber - numbers[digit - CopyOfDigit] * ((int)(Math.Pow(10, (CopyOfDigit - 1))));
                CopyOfDigit--;
            }
            numbers.Add(CopyOfStartNumber);
            int ActualNumber = 0;
            for (int i = 0; i < digit; i++)
            {
                ActualNumber = ActualNumber + numbers[i] * ((int)Math.Pow(StartBase, digit - 1 - i));
            }
            return ActualNumber;
        }
    }
}