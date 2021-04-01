using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
	[Table("Orders")]
	public class OrderEntity : BaseEntity
	{
		private string _email;
		private DateTime _date = DateTime.Now;
		private ICollection<CartOrderItemEntity> _items;
		//private Payment payment;
		private OrderStatuses _orderStatus = OrderStatuses.Pending;
		private AddressEntity _address;
		
		[Required]
		public string Email { get => _email; set => _email = value; }
		[Required]
		public DateTime Date { get => _date; set => _date = value; }
		[Required]
		public virtual ICollection<CartOrderItemEntity> Items { get => _items; set => _items = value; }
		[Required]
		public OrderStatuses OrderStatus { get => _orderStatus; set => _orderStatus = value; }
		[Required]
		public virtual AddressEntity Address { get => _address; set => _address = value; }
	
		public OrderEntity()
		{
			Items = new HashSet<CartOrderItemEntity>();
		}
	}
}
