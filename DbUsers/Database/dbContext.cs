using DbUsers.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Store.Data
{
    public class dbContext : DbContext
    {
        public DbSet<User>Users { get; set; }

        public DbSet<Group> Groups { get; set; }
        

        public dbContext() : base("UserDb")
        {
        }
        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Group>()
             .HasMany(c => c.Users)
             .WithMany(c => c.Groups)
             .Map(t => t.MapLeftKey("GroupId")
                 .MapRightKey("UserId")
                 .ToTable("UserGroup"));
        }
        }
      
    }

