using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class CartOrderItem : BaseDTO
	{
		private string _productName;
		private decimal _price;
		private string _picturePath;
		//[Required]
		//[Range(1, double.MaxValue, ErrorMessage = "Quantity must be atleast 1")]
		private int _quantity;
		private ProductCategory _category;
		private Shop _shop;

		public string ProductName { get => _productName; set => _productName = value; }
		public decimal Price { get => _price; set =>  _price = value; }
		public string PicturePath { get => _picturePath; set => _picturePath = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
		public ProductCategory Category { get => _category; set => _category = value; }
		public Shop Shop { get => _shop; set => _shop = value; }
	}
}
