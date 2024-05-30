using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Domain;
using Products.Domain.Products;

namespace Products.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IReadUnitOfWork _readUnitOfWork;
		public ProductController(IReadUnitOfWork readUnitOfWork)
		{
			_readUnitOfWork = readUnitOfWork;
		}

		[HttpGet]
		public async Task<List<Product>> Get()
		{
			return await _readUnitOfWork.ProductReadRepository.GetAllAsync();
		}


	}
}
