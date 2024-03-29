﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Product : BaseDTO
	{
		private string _name;
		private string _description;
		private string _picturePath;
		private ProductCategory _category;

		public string Name { get => _name; set => _name = value; }
		public string Description { get => _description; set => _description = value; }
		public string PicturePath { get => _picturePath; set => _picturePath = value; }
		public ProductCategory Category { get => _category; set => _category = value; }
	}
}
