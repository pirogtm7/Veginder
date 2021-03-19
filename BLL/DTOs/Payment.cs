using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Payment : BaseDTO
	{
		private string cardNumber4Digits;
		private DateTime dueTime;
		private decimal totalPrice;

	}
}
