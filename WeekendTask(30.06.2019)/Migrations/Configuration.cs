namespace WeekendTask_30._06._2019_.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Services.Description;
    using WeekendTask_30._06._2019_.Entity;
    using Service = Entity.Service;

    internal sealed class Configuration : DbMigrationsConfiguration<WeekendTask_30._06._2019_.Entity.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WeekendTask_30._06._2019_.Entity.DataContext db)
        {
            List<Service> services = new List<Service>()
            {
            new Service() { Name="Web Desing" ,
                            Description ="Lorem ipsum dolor sit amet consecetur adipisicing elit. Cumque ab nihil quam nesciunt.",
                            Icon="icon icon-phonelink" },
            new Service() { Name="Art Direction" ,
                            Description ="Lorem ipsum dolor sit amet consecetur adipisicing elit. Cumque ab nihil quam nesciunt.",
                            Icon="icon icon-format_paint" }
            };

            foreach (var service in services)
            {
                db.Servives.Add(service);
            }
            db.SaveChanges();

            List<Project> projects = new List<Project>()
            {
                new Project() {Name="Project Name 1", Title="Web Application", Photo="img_1.jpg"},
                new Project() {Name="Project Name 2", Title="Branding", Photo="img_2.jpg"}
            };

            foreach (var project in projects)
            {
                db.Projects.Add(project);
            }
            db.SaveChanges();

            base.Seed(db);
        }
    }
}
