using Products.Domain.Base;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Categories
{
	public class Category : BaseEntity
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public string Permalink { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
		public string BannerUrl { get; set; }
		public string IconUrl { get; set; }
		public string ThumbnailUrl { get; set; }

		public ICollection<Product> Products { get; set; }

		public int? ParentCategoryId { get; set; }
		public Category ParentCategory { get; set; }

	}
}
