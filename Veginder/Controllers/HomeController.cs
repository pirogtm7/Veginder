using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Veginder.Models;

namespace Veginder.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		IProductService productService;
		IShopService shopService;

		public HomeController(ILogger<HomeController> logger, IProductService productService,
			IShopService shopService)
		{
			_logger = logger;
			this.productService = productService;
			this.shopService = shopService;
		}

		public IActionResult Index()
		{
			var model = new HomePageModel(shopService.GetAllShops().ToList());
			return View(model);
		}

		public IActionResult ExampleProduct()
		{
			return View();
		}

		public IActionResult ExampleShop()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
