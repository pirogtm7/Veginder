using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veginder.Models;

namespace Veginder.Controllers
{
	public class ProductController : Controller
	{
		IStockService _stockService;

		public ProductController(IStockService stockService)
		{
			_stockService = stockService;
		}

		[HttpGet]
		public IActionResult Products(int? shopId, int? categoryId)
		{
			StocksModel model = new StocksModel(_stockService.GetAllStocks().ToList());

			//probably should do filtering in html/css/js, not here
			//if so, add id's to the model and move if's to html
			if (shopId != null)
			{
				//filter by shop 
			}
			else if (categoryId != null)
			{
				//filter by category
			}

			return View(model);
		}

		public IActionResult ShowProduct(int stockId)
		{
			StockModel model = new StockModel(_stockService.GetStockById(stockId));
			return View(model);
		}
	}
}
