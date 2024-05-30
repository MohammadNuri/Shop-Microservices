using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
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


		public class CategoryConfiguration : IEntityTypeConfiguration<Category>
		{

			//Fluent Validation
			public void Configure(EntityTypeBuilder<Category> builder)
			{
				builder.HasKey(b => b.Id);
				builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
				builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
				builder.Property(p => p.Permalink).IsRequired().HasMaxLength(200);
				builder.Property(p => p.BannerUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://placehold.co/500x100.png");
				builder.Property(p => p.IconUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://placehold.co/85.png");
				builder.Property(p => p.ThumbnailUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://placehold.co/150.png");
				builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
				builder.Property(p => p.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
				builder.HasData(SeedCategories());
			}

			//Seed Data
			internal List<Category> SeedCategories()
			{
				var categories = new List<Category>();
				using (StreamReader r = new StreamReader(@"SeedData/CategorySeed.json"))
				{
					string json = r.ReadToEnd();
					categories = JsonConvert.DeserializeObject<List<Category>>(json);	
				}
				return categories;
			}
		}

	}
}
