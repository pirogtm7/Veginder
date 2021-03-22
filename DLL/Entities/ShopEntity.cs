using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class ShopEntity : BaseEntity
	{
		[Required]
		private string name;
		private string description;
		private string picturePath;
		private string address;
		//[Required]
		//private List<ProductEntity> productEntities = new List<ProductEntity>();

		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
		public string Address { get => address; set => address = value; }
		//public List<ProductEntity> ProductEntities { get => productEntities; set => productEntities = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
	}
}
