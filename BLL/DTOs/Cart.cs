using System;
using System.Collections.Generic;

namespace BLL.DTOs
{
	public class Cart : BaseDTO
	{
		private List<Product> products = new List<Product>();
		private decimal totalPrice;
	}
}
