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
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products {get; set;}
        // public DbSet<Order> orders {get; set;}

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

            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Product>().Property(x => x.Categoryid).HasColumnName("categoryid");
            modelBuilder.Entity<Product>().Property(x => x.QuantityPerUnit).HasColumnName("quantityperunit");
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnName("unitprice");
            modelBuilder.Entity<Product>().Property(x => x.UnitsInStock).HasColumnName("unitsinstock");

            // modelBuilder.Entity<Order>().ToTable("orders");
            // modelBuilder.Entity<Order>().Property(x => x.OrderId).HasColumnName("orderid");
            // modelBuilder.Entity<Order>().Property(x => x.CustomerId).HasColumnName("customerid");
            // modelBuilder.Entity<Order>().Property(x => x.EmployeeId).HasColumnName("employeeid");
            // modelBuilder.Entity<Order>().Property(x => x.Orderdate).HasColumnName("orderdate");
            // modelBuilder.Entity<Order>().Property(x => x.ShippedDate).HasColumnName("shippeddate");
            // modelBuilder.Entity<Order>().Property(x => x.RequiredDate).HasColumnName("requireddate");
            // modelBuilder.Entity<Order>().Property(x => x.Freight).HasColumnName("freight");
            // modelBuilder.Entity<Order>().Property(x => x.ShipName).HasColumnName("shipname");
            // modelBuilder.Entity<Order>().Property(x => x.ShipAddress).HasColumnName("shipaddress");
            // modelBuilder.Entity<Order>().Property(x => x.ShipCity).HasColumnName("shipcity");
            // modelBuilder.Entity<Order>().Property(x => x.ShipPostalCode).HasColumnName("shippostalcode");
            // modelBuilder.Entity<Order>().Property(x => x.ShipCountry).HasColumnName("shipcountry");
        }

    }
}