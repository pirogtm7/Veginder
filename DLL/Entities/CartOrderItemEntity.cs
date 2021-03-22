using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class CartOrderItemEntity : BaseEntity
	{
		[Required]
		private string productName;
		[Required]
		private decimal price;
		private string picturePath;
		[Required]
		[Range(1, double.MaxValue, ErrorMessage = "Quantity must be at least 1")]
		private int quantity;
		[Required]
		private ProductCategoryEntity category;
		[Required]
		private ShopEntity shop;

		public string ProductName { get => productName; set => productName = value; }
		public decimal Price { get => price; set => price = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
		public int Quantity { get => quantity; set => quantity = value; }
		public ProductCategoryEntity Category { get => category; set => category = value; }
		public ShopEntity Shop { get => shop; set => shop = value; }
	}
}
