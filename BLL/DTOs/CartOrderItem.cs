using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class CartOrderItem : BaseDTO
	{
		private string productName;
		private decimal price;
		private string picturePath;
		//[Required]
		//[Range(1, double.MaxValue, ErrorMessage = "Quantity must be atleast 1")]
		private int quantity;
		private string category;
		private Shop shop;

		public string ProductName { get => productName; set => productName = value; }
		public decimal Price { get => price; set => price = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
		public int Quantity { get => quantity; set => quantity = value; }
		public string Category { get => category; set => category = value; }
		public Shop Shop { get => shop; set => shop = value; }
	}
}
