using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Base
    {
        public int Id { get; set; }
        public int StartingBase { get; set; }
        public int StartingNumber { get; set; }
        public int ActualNumber { get; set; }

    }
}