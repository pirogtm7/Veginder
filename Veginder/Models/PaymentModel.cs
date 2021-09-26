using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class PaymentModel
	{
		public Order Order { get; set; } 
		public decimal TotalAmount { get; set; }  
	}
}
