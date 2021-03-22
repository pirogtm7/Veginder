using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Product : BaseDTO
	{
		private string name;
		private string description;
		private decimal price;
		private string picturePath;
		private string category;

		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
		public decimal Price { get => price; set => price = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
		public string Category { get => category; set => category = value; }
	}
}
