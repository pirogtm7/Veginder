using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class CartModel
	{
		public List<CartOrderItem> Items;

		public CartModel(List<CartOrderItem> items)
		{
			Items = items;
		}
	}
}
