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

		public Order(int number)
        {
			this.number = number;
			System.Diagnostics.Debug.WriteLine($"An order object was created " +
				"through initialization constructor with number {0}.\n", this.number);

			Payment testPayment = new Payment();
		
			Payment payment = new Payment(testPayment);
        }
	}
}
