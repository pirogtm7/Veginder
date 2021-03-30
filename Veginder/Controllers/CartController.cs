using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veginder.Models;

namespace Veginder.Controllers
{
	public class CartController : Controller
	{
		IShopService _shopService;
		IStockService _stockService;
		ICartService _cartService;
		public const string CartSessionKey = "CartId";

		public CartController(ICartService cartService, 
			IShopService shopService, IStockService stockService)
		{
			_cartService = cartService;
			_shopService = shopService;
			_stockService = stockService;
		}

		public IActionResult AddItemToCart(int stockId, int quantity)
		{
			Stock stock = _stockService.GetStockById(stockId);

			CartOrderItem item = new CartOrderItem()
			{
				StockId = stockId,
				Quantity = quantity,
				CartId = GetCartId(),
				Price = stock.Price * quantity
			};

			_cartService.AddItemToCart(item);

			return RedirectToAction("ShowProduct", "Product", new { stockId });
		}

		public IActionResult Cart()
		{
			CartModel model = new CartModel(_cartService.GetAllItemsFromCart(GetCartId()));
			return View(model);
		}

		public string GetCartId()
		{
			if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(CartSessionKey)))
			{
				if (!string.IsNullOrWhiteSpace(HttpContext.User.Identity.Name))
				{
					HttpContext.Session.SetString(CartSessionKey, HttpContext.User.Identity.Name);
				}
				else
				{
					Guid tempCartId = Guid.NewGuid();
					HttpContext.Session.SetString(CartSessionKey, tempCartId.ToString());
				}
			}
			return HttpContext.Session.GetString(CartSessionKey);
		}
	}
}
