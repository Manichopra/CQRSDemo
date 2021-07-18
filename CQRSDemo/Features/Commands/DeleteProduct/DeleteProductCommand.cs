using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Features.Commands.DeleteProduct
{
	public class DeleteProductCommand: IRequest
	{
		public Guid ProductId { get; set; }
	}
}
