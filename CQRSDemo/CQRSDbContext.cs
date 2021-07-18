using CQRSDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
	public class CQRSDbContext: DbContext
	{
		public CQRSDbContext(): base()
		{
		}

		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CQRSDemo;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CQRSDbContext).Assembly);

			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = Guid.Parse("{EE272F8B-6096-4CB6-8625-BB4BB2D89E8B}"),
				Name = "Back to the Future",
				Price = 12.99
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = Guid.Parse("{3448D5A4-0F72-4DD7-BF15-C14A46B26C00}"),
				Name = "Jaws",
				Price = 15.99
			});

		}
	}
}
