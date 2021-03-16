using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Business
{
	public class Customer
	{
		private string fullName;
		private string phoneNumber;
		private string address;
		private string password;
		private Cart cart;
		private List<Order> orders;

		public Customer()
        {
			System.Diagnostics.Debug.WriteLine("A customer object was created through default constructor.\n");
			Order order = new Order(5);
        }
	}
}
