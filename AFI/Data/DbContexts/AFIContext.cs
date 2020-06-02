using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.DbContexts
{
    public class AFIContext : DbContext
    {
        public AFIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
