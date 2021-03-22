using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class CartOrderItemEntity : BaseEntity
	{
		[Required]
		private string _productName;
		[Required]
		private decimal _price;
		private string _picturePath;
		[Required]
		[Range(1, double.MaxValue, ErrorMessage = "Quantity must be at least 1")]
		private int _quantity;
		[Required]
		private ProductCategoryEntity _category;
		[Required]
		private ShopEntity _shop;

		public string ProductName { get => _productName; set => _productName = value; }
		public decimal Price { get => _price; set => _price = value; }
		public string PicturePath { get => _picturePath; set => _picturePath = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
		public ProductCategoryEntity Category { get => _category; set => _category = value; }
		public ShopEntity Shop { get => _shop; set => _shop = value; }
	}
}
