using AutoMapper;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Products
{
	public class ProductMappingProfile : Profile
	{
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductReqDto>().ReverseMap();
			//Example of Custom Mapping with CategoryTitle_Id as a Custom Property
			CreateMap<Product, ProductResDto>().ForMember(dest => dest.CategoryTitle_Id,
			   config =>
				   config.MapFrom(src => $"{src.Category.Title}({src.CategoryId})")).ReverseMap();
		}
    }
}
