using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exocortex.Data
{
    public class ExocortexDbContext : DbContext
    {

    }

    public class Tag
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}