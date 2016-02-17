using exocortex.Models.exocortex;
using Microsoft.Data.Entity;

namespace exocortex.Models
{
    public class ExocortexDbContext : DbContext
    {

        public ExocortexDbContext()
        { }

       

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Recall> Recalls { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }



    }
}