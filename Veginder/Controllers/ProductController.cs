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
		IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public IActionResult Products(int? shopId, int? categoryId)
		{
			ProductsModel model = new ProductsModel(_productService.GetAllProducts().ToList());

			//probably should do sorting in html/css/js, not here
			//if so, add id's to the model and move if's to html
			if (shopId != null)
			{
				//sort by shop 
			}
			else if (categoryId != null)
			{
				//sort by category
			}

			return View(model);
		}
	}
}
