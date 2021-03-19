using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Shop : BaseDTO
	{
		private string name;
		private string address;
		private string category;
		private List<Product> products;
	}
}
