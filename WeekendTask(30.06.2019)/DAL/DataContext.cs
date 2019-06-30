using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeekendTask_30._06._2019_.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Servives { get; set; }
        public DbSet<SectionFeature> SectionFeatures { get; set; }
        public DbSet<Setting> Settings { get; set; }
    }
}