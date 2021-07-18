using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Features.Queries.GetProductsList
{
	public class GetProductsListQuery: IRequest<List<ProductListViewModel>>
	{
	}
}
