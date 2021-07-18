using CQRSDemo.Features.Commands.CreateProduct;
using CQRSDemo.Features.Commands.UpdateProduct;
using CQRSDemo.Features.Queries.GetProductsList;
using MediatR;
using System;

namespace CQRSDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			
			// To show a list of all products
			var allProducts = new GetProductsListQuery();

			// To create a new product
			new CreateProductCommand()
			{
				Name = "Inception",
				Price = 22.00
			};

			Console.ReadKey();
		}
	}
}
