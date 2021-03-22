using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class ProductEntity : BaseEntity
	{
		[Required]
		private string _name;
		private string _description;
		[Required]
		private decimal _price;
		private string _picturePath;
		[Required]
		private ProductCategoryEntity _category;

		public string Name { get => _name; set => _name = value; }
		public string Description { get => _description; set => _description = value; }
		public decimal Price { get => _price; set => _price = value; }
		public string PicturePath { get => _picturePath; set => _picturePath = value; }
		public ProductCategoryEntity Category { get => _category; set => _category = value; }
	}
}
