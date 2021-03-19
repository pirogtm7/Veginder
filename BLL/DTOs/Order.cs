using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Order : BaseDTO
	{
		private int number;
		private DateTime date;
		private Payment payment;
		private string orderStatus;
		private Cart cart;

	}
}
