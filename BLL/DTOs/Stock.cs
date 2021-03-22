using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Stock
	{
		private Shop _shop;
		private Product _product;
		private int _quantity;

		public Shop Shop { get => _shop; set =>  _shop = value; }
		public Product Product { get => _product; set => _product = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
	}
}
