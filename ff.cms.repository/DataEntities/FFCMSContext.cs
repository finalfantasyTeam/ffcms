namespace ff.cms.repository.DataEntities
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class FFCMSContext : DbContext
    {
        public FFCMSContext() : base("FinalFantasy")
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
