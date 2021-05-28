using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Order : BaseDTO
	{
		private string _email;
		private DateTime _date = DateTime.Now;
		private List<CartOrderItem> _cartOrderItems;
		private decimal _totalAmount;
		private string _paymentIntentId;
		private OrderStatus _orderStatus;
		private int _orderStatusId;
		private Address _address;

		public string Email { get => _email; set => _email = value; }
		public DateTime Date { get => _date; set => _date = value; }
		public Address Address { get => _address; set => _address = value; }
		public decimal TotalAmount { get => _totalAmount; set => _totalAmount = value; }
		public string PaymentIntentId { get => _paymentIntentId; set => _paymentIntentId = value; }
		public int OrderStatusId { get => _orderStatusId; set => _orderStatusId = value; }
		public List<CartOrderItem> CartOrderItems { get => _cartOrderItems; set => _cartOrderItems = value; }
		public OrderStatus OrderStatus { get => _orderStatus; set => _orderStatus = value; }
	}
}
