using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "admin" },
                new Role { Id = 2, Name = "editor" },
                new Role { Id = 3, Name = "Arthur" }
            );

           // modelBuilder.Entity<Permission>().HasData(
           //    new Permission { Id = 1, Name = "all" },
           //    new Permission { Id = 2, Name = "post" },
           //    new Permission { Id = 1, Name = "edit" },
           //    new Permission { Id = 1, Name = "delete" }

           //);
        }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Survey> Surveies { get; set; }

        public DbSet<SurveyOption> SurveiesOptions { get; set; }

    }
}
