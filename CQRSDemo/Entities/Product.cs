using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Entities
{
	public class Product
	{
		public Guid ProductId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
