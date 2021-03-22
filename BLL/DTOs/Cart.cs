using System;
using System.Collections.Generic;

namespace BLL.DTOs
{
	public class Cart : BaseDTO
	{
		private List<CartOrderItem> items;
		//public string PaymentIntentId { get; set; }

		public List<CartOrderItem> Items { get => items; set => items = value; }

	}
}
