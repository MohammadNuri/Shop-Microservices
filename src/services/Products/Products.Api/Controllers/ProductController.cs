using AutoMapper;
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
		private readonly IMapper _mapper;
		public ProductController(IReadUnitOfWork readUnitOfWork, IMapper mapper)
		{
			_readUnitOfWork = readUnitOfWork;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<List<ProductResDto>> Get()
		{
			var productRes = 
				_mapper.Map<List<ProductResDto>>(await _readUnitOfWork.ProductReadRepository.GetAllAsync());
			return productRes;
		}
	}
}
