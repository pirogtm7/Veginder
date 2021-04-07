using BLL.DTOs;
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

		public IActionResult ShowProduct(int stockId, int? changedQuantity)
		{
			StockModel model = new StockModel(_stockService.GetStockById(stockId));
			
			if (changedQuantity != null)
			{
				model.Quantity = (int)changedQuantity;
			}

			return View(model);
		}

		public IActionResult IncreaseQuantity(int stockId, int quantity)
		{
			Stock stock = _stockService.GetStockById(stockId);
			int? changedQuantity = null;

			if (stock.Quantity > quantity)
			{
				changedQuantity = quantity + 1;
			}

			return RedirectToAction("ShowProduct", "Product", new { stockId, changedQuantity });
		}

		public IActionResult DecreaseQuantity(int stockId, int quantity)
		{
			int? changedQuantity = null;

			if (quantity > 1)
			{
				changedQuantity = quantity - 1;
			}

			return RedirectToAction("ShowProduct", "Product", new { stockId, changedQuantity });
		}
	}
}
