namespace ff.cms.repository.Migrations
{
    using DataEntities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FFCMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FFCMSContext context)
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
            List<Option> lstOptions = new List<Option>()
            {
                new Option{ StrKey = "SiteName", StrValue="FF CMS", UserModified="admin", IsApplied = true }
            };

            lstOptions.ForEach(o => context.Options.Add(o));
            context.SaveChanges();

            List<Author> lstAuthors = new List<Author>()
            {
                new Author { FirstName = "Super", LastName="Admin", UserName="admin", Password= "1234", IsAvailable= true }
            };

            lstAuthors.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();
        }
    }
}
