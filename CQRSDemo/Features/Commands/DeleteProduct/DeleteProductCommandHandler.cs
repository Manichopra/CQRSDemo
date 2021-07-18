using AutoMapper;
using CQRSDemo.Entities;
using CQRSDemo.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Commands.DeleteProduct
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
	{
		private readonly IRepository<Product> _productRepository;
		private readonly IMapper _mapper;

		public DeleteProductCommandHandler(IMapper mapper, IRepository<Product> productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
		{
			var productToDelete = await _productRepository.GetAsync(request.ProductId);
			
			await _productRepository.DeleteAsync(productToDelete);

			return Unit.Value;
		}
	}
}
