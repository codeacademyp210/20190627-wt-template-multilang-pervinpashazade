using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeekendTask_30._06._2019_.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            List<Service> services = new List<Service>()
            {
            new Service() { Id=1, Name="Web Desing" ,
                            Description ="Lorem ipsum dolor sit amet consecetur adipisicing elit. Cumque ab nihil quam nesciunt.",
                            Icon="icon icon-phonelink" },
            new Service() { Id=2, Name="Art Direction" ,
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
                new Project() {Id=1, Name="Project Name 1", Title="Web Application", Photo="img_1.jpg"},
                new Project() {Id=2, Name="Project Name 2", Title="Branding", Photo="img_2.jpg"}
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