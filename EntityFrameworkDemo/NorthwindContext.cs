using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        //virtual :
        //override : üzerine yazmak için moetod virtual olması gerekiyor.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent mapping
            //modelBuilder.HasDefaultSchema("admin");
            //modelBuilder.Entity<Product>().ToTable("Products");
           // modelBuilder.Entity<Product>().Property(p => p.ProductId).HasColumnName("ProductId");
        }

    }
}
