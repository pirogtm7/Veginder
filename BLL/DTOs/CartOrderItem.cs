using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class CartOrderItem : BaseDTO
	{
		private decimal _price;
		private int _quantity;
		private string _cartId;
		private Stock _stock;
		private int _stockId;

		public decimal Price { get => _price; set => _price = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
		public string CartId { get => _cartId; set => _cartId = value; }
		public Stock Stock { get => _stock; set => _stock = value; }
		public int StockId { get => _stockId; set => _stockId = value; }

	}
}
