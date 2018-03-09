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
    }
}