using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class StockEntity : BaseEntity
	{
		[Required]
		private ShopEntity _shop;
		[Required]
		private ProductEntity _product;
		[Required]
		[Range(0, int.MaxValue)]
		private int _quantity;

		public ShopEntity Shop { get => _shop; set => _shop = value; }
		public ProductEntity Product { get => _product; set => _product = value; }
		public int Quantity { get => _quantity; set => _quantity = value; }
	}
}
