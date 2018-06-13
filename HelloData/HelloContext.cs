using HelloDomain;
using Microsoft.EntityFrameworkCore;

namespace HelloData
{
    public class HelloContext : DbContext
    {
        public HelloContext(DbContextOptions<HelloContext> options)
            : base(options)
        { }

        public DbSet<Msg> Messages { get; set; }

    }

    
}
