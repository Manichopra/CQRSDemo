using AutoMapper;
using CQRSDemo.Entities;
using CQRSDemo.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Commands.CreateProduct
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public CreateProductCommandHandler(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var @product = _mapper.Map<Product>(request);

			@product = await _productRepository.CreateAsync(@product);

			return @product.ProductId;
		}
	}
}
