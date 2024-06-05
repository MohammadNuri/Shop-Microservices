using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Commands.Create;
using Products.Domain.Products;

namespace Products.Api.GQL.Mutations
{
	public static class ProductMutatios
	{
		public static void ProductsMutations(this ObjectGraphType schema, IMediator mediator)
		{
			schema.FieldAsync<ProductResType>(
				"addProduct",
				"Is used to add a new product to the database",
				arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "productInput", Description = "Product Input Parameter" }),
				resolve: async context =>
				{
					var addProduct = context.GetArgument<AddProductCommand>("productInput");

					ProductResDto addProductRes = new ProductResDto();
					try
					{
						addProductRes = await mediator.Send(addProduct);
					}
					catch (Exception ex)
					{
						context.Errors.Add(new ExecutionError(ex.Message));
						return null;
					}

					return addProductRes;
				}
				);



		}
    }
}
