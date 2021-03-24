using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class ProductsModel
	{
		public List<Product> Products;

		public ProductsModel(List<Product> products)
		{
			Products = products;
		}
	}
}
