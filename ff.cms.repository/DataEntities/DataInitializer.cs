namespace ff.cms.repository.DataEntities
{
    using System.Collections.Generic;
    using System.Data.Entity;

    public class DataInitializer : DropCreateDatabaseIfModelChanges<FFCMSContext>
    {
        protected override void Seed(FFCMSContext context)
        {
            List<Option> lstOptions = new List<Option>()
            {
                new Option{ StrKey = "SiteName", StrValue="FF CMS", UserModified="admin" , IsApplied = true }
            };

            lstOptions.ForEach(o => context.Options.Add(o));
            context.SaveChanges();

            List<Author> lstAuthors = new List<Author>()
            {
                new Author { FirstName = "Super", LastName="Admin", UserName="admin", Password= "1234", IsAvailable = true }
            };

            lstAuthors.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();
        }
    }
}
