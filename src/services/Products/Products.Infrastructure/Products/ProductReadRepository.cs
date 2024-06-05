﻿using Microsoft.EntityFrameworkCore;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}