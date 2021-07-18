using CQRSDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(CQRSDbContext dbContext) : base(dbContext)
		{
		}
	}
}
