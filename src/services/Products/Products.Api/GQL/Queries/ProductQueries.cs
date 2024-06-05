using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Queries.GetProductsList;
#pragma warning disable CS0618
#pragma warning disable GQL004

namespace Products.Api.GQL.Queries
{
	public static class ProductQueries
	{
		public static void ProductsQueries(this ObjectGraphType schema, IMediator mediator)
		{
			schema.FieldAsync<ListGraphType<ProductResType>>(
				"getProducts",
				description: "return list of products",
				resolve: async context => await mediator.Send(new GetProductsListQuery())
			);
		}
	}
}
