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
		private string email;
		private string password;
		private Cart cart;
		private List<Order> orders = new List<Order>();
	}
}
