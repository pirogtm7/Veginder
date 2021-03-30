using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface ICartService
	{
		void AddItemToCart(CartOrderItem item);
		List<CartOrderItem> GetAllItemsFromCart(string cartId);
	}
}
