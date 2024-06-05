using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Delete;
using Products.Application.Products.Commands.Update;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain;
using Products.Domain.Products;

namespace Products.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ProductResDto>> Get()
        {
            return await _mediator.Send(new GetProductsListQuery());
        }

        [HttpPost]
		public async Task<ProductResDto> Post(AddProductCommand request)
        {
            return await _mediator.Send(request);
        }

		[HttpPut("{id}")]
		public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
		{
            if (id != request.Id)
            {
                return BadRequest("Id in body and query must be equal");
            }

            var res = await _mediator.Send(request);
            return res;
		}

        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);

            return res;
        }
	}
}
