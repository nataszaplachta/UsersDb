using DbUsers.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Store.Data
{
    public class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public System.Data.Entity.DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Group> Groups { get; set; }


        public UserDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<UserDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGroup>()
                .HasKey(x => new { x.UserId, x.GroupId });

            modelBuilder.Entity<UserGroup>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserGroups)
                .HasForeignKey(y => y.GroupId);

            modelBuilder.Entity<UserGroup>()
                .HasOne(x => x.Group)
                .WithMany(y => y.UserGroups)
                .HasForeignKey(y => y.UserId);
        }
       
        }
        }
      
   

