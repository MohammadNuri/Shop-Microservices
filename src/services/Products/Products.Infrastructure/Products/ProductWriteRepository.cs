using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Products
{
	public class ProductWriteRepository : IProductWriteRepository
	{
		private readonly ProductDbContext _context;
        public ProductWriteRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddAsync(Product product)
		{
			var productEntry = await _context.AddAsync(product);
			await _context.SaveChangesAsync();
			return productEntry.Entity;
		}

		public async Task<Product> UpdateAsync(Product product)
		{
			var productEntry = _context.Update(product);
			await _context.SaveChangesAsync();
			return productEntry.Entity;
		}

		public async Task DeleteAsync(Product product)
		{
			_context.Remove(product);
			await _context.SaveChangesAsync();
		}

	}
}
