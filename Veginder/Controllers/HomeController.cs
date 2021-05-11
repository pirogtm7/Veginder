using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Exceptions;
using BLL.Interfaces;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Veginder.Models;

namespace Veginder.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		IShopService _shopService;
		ICategoryService _categoryService;
		IStockService stockService;

		public HomeController(ILogger<HomeController> logger,
			IShopService shopService, ICategoryService categoryService, IStockService stockService)
		{
			_logger = logger;
			_shopService = shopService;
			_categoryService = categoryService;
			this.stockService = stockService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			//VeginderDbContext context = new VeginderDbContext();
			//var stocks = context.Stocks
			//	.Include(s => s.Product)
			//	.ToList();

			try
			{
				stockService.CheckStock(0);
			}
			catch (ItemNotInStockException e)
			{
				Debug.WriteLine(e.Message); 
			}


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
