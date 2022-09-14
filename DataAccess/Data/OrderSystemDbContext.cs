using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.DatabaseContext
{
    public class OrderSystemDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OrderSystemDb;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 123, Name = "Elma", ProductCode = "3007975", Amount = 20 },
               new Product { Id = 124, Name = "Armut", ProductCode = "11", Amount = 40 },
               new Product { Id = 1234, Name = "Ayva", ProductCode = "w-l-12532w2i", Amount = 30 },
               new Product { Id = 1235, Name = "Maydonoz", ProductCode = "065781-31966", Amount = 12 },
               new Product { Id = 1236, Name = "Havuç", ProductCode = "12321321", Amount = 5 }
               );
            modelBuilder.Entity<Order>().HasData(
               new Order { Id = 123, CompanyId = 1, TotalAmount = 40, Date = DateTime.Parse("11-02-2022") },
               new Order { Id = 124, CompanyId = 1, TotalAmount = 100, Date = DateTime.Parse("11-02-2022") }
               );
            modelBuilder.Entity<OrderProduct>().HasData(
               new OrderProduct { Id = 123, OrderId = 123, ProductId = 123 },
               new OrderProduct { Id = 124, OrderId = 123, ProductId = 123 },
               new OrderProduct { Id = 1234, OrderId = 124, ProductId = 1234 },
               new OrderProduct { Id = 1235, OrderId = 124, ProductId = 1234 },
               new OrderProduct { Id = 1236, OrderId = 124, ProductId = 124 }
               );
        }



    }
}
