using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class HomePageModel
	{
		private List<Shop> _shops;
		private List<ProductCategory> _categories;
		public List<Shop> Shops { get => _shops; set => _shops = value; }
		public List<ProductCategory> Categories { get => _categories; set => _categories = value; }

		public HomePageModel(List<Shop> shops, List<ProductCategory> categories)
		{
			_shops = shops;
			_categories = categories;
		}

	}
}
