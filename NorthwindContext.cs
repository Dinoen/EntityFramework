using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("host=localhost;db=northwind;uid=postgres;pwd=Palle0410");
            optionsBuilder.EnableSensitiveDataLogging();
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
        }


    }
}