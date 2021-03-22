﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class ProductEntity : BaseEntity
	{
		[Required]
		private string name;
		private string description;
		[Required]
		private decimal price;
		private string picturePath;
		[Required]
		private ProductCategoryEntity category;

		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
		public decimal Price { get => price; set => price = value; }
		public string PicturePath { get => picturePath; set => picturePath = value; }
		public ProductCategoryEntity Category { get => category; set => category = value; }
	}
}
