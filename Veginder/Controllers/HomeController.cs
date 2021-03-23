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
		IProductService _productService;
		IShopService _shopService;
		ICategoryService _categoryService;

		public HomeController(ILogger<HomeController> logger, IProductService productService,
			IShopService shopService, ICategoryService categoryService)
		{
			_logger = logger;
			_productService = productService;
			_shopService = shopService;
			_categoryService = categoryService;
		}

		public IActionResult Index()
		{
			HomePageModel model = new HomePageModel(_shopService.GetAllShops().ToList(),
				_categoryService.GetAllCategories().ToList());
			return View(model);
		}

		public IActionResult ExampleProduct()
		{
			return View();
		}

		public IActionResult ExampleShop()
		{
			var model = new HomePageModel(_shopService.GetAllShops().ToList(),
				_categoryService.GetAllCategories().ToList());
			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
