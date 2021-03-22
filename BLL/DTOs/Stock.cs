using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Stock
	{
		private Shop shop;
		private Product product;
		private int quantity;

		public Shop Shop { get => shop; set => shop = value; }
		public Product Product { get => product; set => product = value; }
		public int Quantity { get => quantity; set => quantity = value; }
	}
}
