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
		public List<Shop> Shops { get => _shops; set => _shops = value; }

		public HomePageModel(List<Shop> shops)
		{
			_shops = shops;
		}

	}
}
