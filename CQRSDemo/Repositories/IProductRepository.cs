using CQRSDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Repositories
{
	public interface IProductRepository : IRepository<Product>
	{
	}
}
