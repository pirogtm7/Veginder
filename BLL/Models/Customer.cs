using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
	public class Customer : User
	{
		private string fullName;
		private string phoneNumber;
		private string address;
		private string password;
		private Cart cart;
		private List<Order> orders;

	}
}
