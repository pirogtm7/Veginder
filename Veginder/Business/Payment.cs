using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

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
			cardNumber = "123";
			dueTime = DateTime.Now;
			cvv = 567;
			ownerName = "Some Name";
			totalPrice = 399;
        }

		public Payment(Payment payment)
        {
			this.cardNumber = payment.cardNumber;
			this.dueTime = payment.dueTime;
			this.cvv = payment.cvv;
			this.ownerName = payment.ownerName;
			this.totalPrice = payment.totalPrice;

			Debug.WriteLine($"A payment object was created " +
				"through copy constructor with the same values: " +
				"\nCard number: {0}, due time: {1}, CVV: {2}, owner name: {3}, total price: {4}.", 
				this.cardNumber, this.dueTime, this.cvv, this.ownerName, this.totalPrice);
        }
	}
}
