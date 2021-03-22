using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class StockEntity : BaseEntity
	{
		[Required]
		private ShopEntity shop;
		[Required]
		private ProductEntity product;
		[Required]
		[Range(0, int.MaxValue)]
		private int quantity;

		public ShopEntity Shop { get => shop; set => shop = value; }
		public ProductEntity Product { get => product; set => product = value; }
		public int Quantity { get => quantity; set => quantity = value; }
	}
}
