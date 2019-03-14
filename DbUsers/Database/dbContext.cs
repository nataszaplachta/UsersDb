using DbUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace Store.Data
{
    public class dbContext : DbContext
    {
        public DbSet<User>Users { get; set; }

        public DbSet<Group> Groups { get; set; }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {

        }
    }
}
