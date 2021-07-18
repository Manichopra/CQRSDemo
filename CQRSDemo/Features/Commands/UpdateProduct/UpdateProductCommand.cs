using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Features.Commands.UpdateProduct
{
	public class UpdateProductCommand: IRequest
	{
		public Guid ProductId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
