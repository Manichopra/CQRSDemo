using AutoMapper;
using CQRSDemo.Entities;
using CQRSDemo.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Commands.UpdateProduct
{
	public class UpdateProductCommandHandler: IRequestHandler<UpdateProductCommand>
	{
		private readonly IRepository<Product> _productRepository;
		private readonly IMapper _mapper;

		public UpdateProductCommandHandler(IMapper mapper, IRepository<Product> productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
		{
			var productToUpdate = await _productRepository.GetAsync(request.ProductId);

			_mapper.Map(request, productToUpdate, typeof(UpdateProductCommand), typeof(Product));

			await _productRepository.UpdateAsync(productToUpdate);

			return Unit.Value;
		}
	}
}
