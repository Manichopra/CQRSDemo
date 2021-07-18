using AutoMapper;
using CQRSDemo.Entities;
using CQRSDemo.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Queries.GetProductsList
{
	public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductListViewModel>>
	{
		private readonly IRepository<Product> _productRepository;
		private readonly IMapper _mapper;

		public GetProductsListQueryHandler(IMapper mapper, IRepository<Product> productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<List<ProductListViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
		{
			var allProducts = await _productRepository.GetAllAsync();
			return _mapper.Map<List<ProductListViewModel>>(allProducts);
		}
	}
}
