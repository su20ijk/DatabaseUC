﻿using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repository
{
    public class MeterstoFeetRepo
    {
        private ApplicationDbContext context;
        public MeterstoFeetRepo()
        {
            context = new ApplicationDbContext();
        }
        
    }
}