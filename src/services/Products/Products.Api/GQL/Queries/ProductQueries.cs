using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types;
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

			schema.FieldAsync<PaginationResType<ListGraphType<ProductResType>>>(
				"getProductByFilter",
				"return list of filtered products",
				arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductFilterType>>
				{
					Name = "filter",
				}),
				resolve: async context =>
				{
					var filterParams = context.GetArgument<GetProductsListQuery>("filter");
					var res = await mediator.Send(filterParams);
					return res;
				}

			);
		}
	}
}
