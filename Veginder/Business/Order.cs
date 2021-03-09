using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Business
{
	public class Order
	{
		private int number;
		private DateTime date;
		private Payment payment;
		private string orderStatus;
		private Customer customer;
		private Cart cart;
	}
}
