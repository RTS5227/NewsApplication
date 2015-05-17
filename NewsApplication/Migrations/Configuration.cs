namespace NewsApplication.Migrations
{
    using NewsApplication.Models.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsApplication.Infrastructure.ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NewsApplication.Infrastructure.ApplicationDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.States.AddOrUpdate(
                p => p.Name,
                new State { Name = "Asia" },
                new State { Name = "Europe" },
                new State { Name = "Africa" }
                );
            context.Categories.AddOrUpdate(
                p => p.Name,
                new Category { Name = "Health" },
                new Category { Name = "Crime" },
                new Category { Name = "Politics " }
                );
        }
    }
}
