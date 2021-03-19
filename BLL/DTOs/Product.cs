using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Product : BaseDTO
	{
		private int index;
		private string name;
		private decimal price;
		private string type;
		private Categories category;
	}

	public enum Categories
	{
		Milk,
		Meat
	}
}
