using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Business
{
	public class Payment
	{
		private string cardNumber;
		private DateTime dueTime;
		private int cvv;
		private string ownerName;
		private decimal totalPrice;

		public Payment()
        {

        }

		public Payment(Payment payment)
        {
			this.cardNumber = payment.cardNumber;
			this.dueTime = payment.dueTime;
			this.cvv = payment.cvv;
			this.totalPrice = payment.totalPrice;

			Console.WriteLine("A payment object was created " +
				"through copy constructor");
        }
	}
}
