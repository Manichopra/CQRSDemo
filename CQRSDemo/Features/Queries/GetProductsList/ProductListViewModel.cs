using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Features.Queries.GetProductsList
{
	public class ProductListViewModel
	{
		public Guid ProductId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
