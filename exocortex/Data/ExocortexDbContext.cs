using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace exocortex.Data
{
    public class ExocortexDbContext : DbContext
    {

        public ExocortexDbContext()
        { }

        public ExocortexDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }




        public DbSet<Entry> Entries { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Recall> Recalls { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}