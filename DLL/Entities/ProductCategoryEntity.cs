using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace DLL.Entities
{
	public class ProductCategoryEntity : BaseEntity
	{
		[Required]
		private string name;

		public string Name { get => name; set => name = value; }
	}
}
