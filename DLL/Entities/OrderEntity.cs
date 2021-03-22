using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class OrderEntity : BaseEntity
	{
		[Required]
		private string email;
		[Required]
		private DateTime date = DateTime.Now;
		[Required]
		private List<CartOrderItemEntity> itemEntities = new List<CartOrderItemEntity>();
		//private Payment payment;
		[Required]
		private OrderStatuses orderStatus = OrderStatuses.Pending;
		[Required]
		private AddressEntity address;
		[Required]
		private CartEntity cart;

		public string Email { get => email; set => email = value; }
		public DateTime Date { get => date; set => date = value; }
		public List<CartOrderItemEntity> ItemEntities { get => itemEntities; set => itemEntities = value; }
		public OrderStatuses OrderStatus { get => orderStatus; set => orderStatus = value; }
		public AddressEntity Address { get => address; set => address = value; }
		public CartEntity Cart { get => cart; set => cart = value; }
	}
}
