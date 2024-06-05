using Microsoft.EntityFrameworkCore;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8603

namespace Products.Infrastructure.Products
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly ProductDbContext _context;
        public ProductReadRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(c => c.Category).ToListAsync();
        }

        public async Task<Product> GetAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
        }

		public async Task<Product> GetAsyncNoTracking(int id)
		{
			return await _context.Products.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
		}

        public async Task<Tuple<List<Product>, int>> GetByFilterPagedAsync(ProductFilterPageReqDto request)
        {
			var filteredProducts = _context.Products.AsQueryable();

			if (request.Id != 0)
			{
				filteredProducts = filteredProducts.Where(p => p.Id == request.Id);
			}

			if (!string.IsNullOrWhiteSpace(request.SearchTerm))
			{
				request.SearchTerm = request.SearchTerm.Trim().ToLower();
				filteredProducts = filteredProducts.Where(p => p.Title.ToLower().Contains(request.SearchTerm)
															   || p.Description.ToLower().Contains(request.SearchTerm)
															   || p.Code.ToLower().Contains(request.SearchTerm));

			}

			if (request.MinPrice != null)
			{
				filteredProducts = filteredProducts.Where(p => p.Price >= request.MinPrice);
			}

			if (request.MaxPrice != null)
			{
				filteredProducts = filteredProducts.Where(p => p.Price <= request.MaxPrice);
			}


			if (request.CategoryId != 0)
			{
				filteredProducts = filteredProducts.Where(p => p.CategoryId == request.CategoryId);
			}

			int countOfFilteredProducts = filteredProducts.Count();
			filteredProducts = filteredProducts.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);


			return
				Tuple.Create(await filteredProducts.ToListAsync(), countOfFilteredProducts);

		}
	}
}
