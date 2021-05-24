using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veginder.Models;

namespace VeginderAPI.Controllers
{
	[Route("api/Cart")]
	[ApiController]
	public class CartController : ControllerBase
	{
		ICartService _cartService;

		public CartController(ICartService cartService)
		{
			_cartService = cartService;
		}

		[HttpGet("{cartId}")]
		public ActionResult<IEnumerable<CartModel>> GetCart(string cartId)
		{
			return Ok(new CartModel(_cartService.GetAllItemsFromCart(cartId)));
		}

		[HttpDelete("{id}/{stockId}")]
		public ActionResult DeleteItem(int id, int stockId)
		{
			_cartService.DeleteItem(id, stockId);

			return NoContent();
		}
	}
}
