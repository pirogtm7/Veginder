using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class ShopEntity : BaseEntity
	{
		[Required]
		private string _name;
		private string _description;
		private string _picturePath;
		private string _address;
		//[Required]
		//private List<ProductEntity> productEntities = new List<ProductEntity>();

		public string Name { get => _name; set => _name = value; }
		public string Description { get => _description; set => _description = value; }
		public string Address { get => _address; set => _address = value; }
		//public List<ProductEntity> ProductEntities { get => productEntities; set => productEntities = value; }
		public string PicturePath { get => _picturePath; set => _picturePath = value; }
	}
}
