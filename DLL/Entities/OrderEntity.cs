using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class OrderEntity : BaseEntity
	{
		[Required]
		private string _email;
		[Required]
		private DateTime _date = DateTime.Now;
		[Required]
		private List<CartOrderItemEntity> _itemEntities = new List<CartOrderItemEntity>();
		//private Payment payment;
		[Required]
		private OrderStatuses _orderStatus = OrderStatuses.Pending;
		[Required]
		private AddressEntity _address;
		[Required]
		private CartEntity _cart;

		public string Email { get => _email; set => _email = value; }
		public DateTime Date { get => _date; set => _date = value; }
		public List<CartOrderItemEntity> ItemEntities { get => _itemEntities; set => _itemEntities = value; }
		public OrderStatuses OrderStatus { get => _orderStatus; set => _orderStatus = value; }
		public AddressEntity Address { get => _address; set => _address = value; }
		public CartEntity Cart { get => _cart; set => _cart = value; }
	}
}
