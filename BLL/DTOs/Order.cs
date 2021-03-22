using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Order : BaseDTO
	{
		private string email;
		private DateTime date = DateTime.Now;
		private List<CartOrderItem> items;
		//private Payment payment;
		private string orderStatus;
		private Address address;
		private Cart cart;

		public string Email { get => email; set => email = value; }
		public DateTime Date { get => date; set => date = value; }
		public List<CartOrderItem> Items { get => items; set => items = value; }
		public string OrderStatus { get => orderStatus; set => orderStatus = value; }
		public Address Address { get => address; set => address = value; }
		public Cart Cart { get => cart; set => cart = value; }
	}
}
