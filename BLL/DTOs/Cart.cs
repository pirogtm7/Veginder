using System;
using System.Collections.Generic;

namespace BLL.DTOs
{
	public class Cart : BaseDTO
	{
		private List<CartOrderItem> _items;
		//public string PaymentIntentId { get; set; }

		public List<CartOrderItem> Items { get => _items; set => _items = value; }

	}
}
