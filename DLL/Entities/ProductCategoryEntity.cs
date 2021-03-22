﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace DLL.Entities
{
	public class ProductCategoryEntity : BaseEntity
	{
		[Required]
		private string _name;

		public string Name { get => _name; set => _name = value; }
	}
}
