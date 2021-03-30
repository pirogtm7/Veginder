using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Order : BaseDTO
	{
		private string _email;
		private DateTime _date = DateTime.Now;
		private List<CartOrderItem> _items;
		//private Payment payment;
		private string _orderStatus;
		private Address _address;

		public string Email { get => _email; set => _email = value; }
		public DateTime Date { get => _date; set => _date = value; }
		public List<CartOrderItem> Items { get => _items; set => _items = value; }
		public string OrderStatus { get => _orderStatus; set => _orderStatus = value; }
		public Address Address { get => _address; set => _address = value; }
	}
}
