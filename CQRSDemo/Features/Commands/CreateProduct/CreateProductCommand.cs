using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Features.Commands.CreateProduct
{
	public class CreateProductCommand: IRequest<Guid>
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
