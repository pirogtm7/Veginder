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
			Console.WriteLine("A customer object was created");
			Order order = new Order(5);
        }
	}
}
