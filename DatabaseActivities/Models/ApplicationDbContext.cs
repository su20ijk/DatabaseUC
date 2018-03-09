﻿using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DatabaseActivities.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Base> Base { get; set; }
        public DbSet<PoundToKilo> PoundsToKilos { get; set; }
        public DbSet<HorsetoBlock> HorsestoBlocks { get; set; }
       // public DbSet<MeterstoFeet> MetertoFoot { get; set; }
    }
}