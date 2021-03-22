using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class CartEntity : BaseEntity
	{
		[Required]
		private List<CartOrderItemEntity> itemEntities = new List<CartOrderItemEntity>();

		public List<CartOrderItemEntity> ItemEntities { get => itemEntities; set => itemEntities = value; }
		//public string PaymentIntentId { get; set; }
	}
}
