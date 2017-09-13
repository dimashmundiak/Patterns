using System.Data.Entity;

namespace Proxy
{
    public class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
