using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class HomePageModel
	{
		public List<Shop> shops;

		public HomePageModel(List<Shop> shops)
		{
			this.shops = shops;
		}
	}
}
