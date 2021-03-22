using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class CartEntity : BaseEntity
	{
		[Required]
		private List<CartOrderItemEntity> _itemEntities = new List<CartOrderItemEntity>();

		public List<CartOrderItemEntity> ItemEntities { get => _itemEntities; set => _itemEntities = value; }
		//public string PaymentIntentId { get; set; }
	}
}
