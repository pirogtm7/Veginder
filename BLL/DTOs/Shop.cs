using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Shop : BaseDTO
	{
		private string name;
		private string description;
		private string picturePath;
		private string address;
		//private List<Product> products;

		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
		public string Address { get => address; set => address = value; }
		//public List<Product> Products { get => products; set => products = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
	}
}
