using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Stock : BaseDTO
	{
		private Shop _shop;
		private Product _product;
		private decimal _price;
		private int _quantity;

		public Shop Shop { get => _shop; set =>  _shop = value; }
		public Product Product { get => _product; set => _product = value; }		
		public decimal Price { get => _price; set => _price = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
	}
}
