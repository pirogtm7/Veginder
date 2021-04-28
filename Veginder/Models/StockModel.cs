using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class StockModel
	{
		public Stock Stock;
		//[Range(1, double.MaxValue, ErrorMessage = "Quantity must be at least 1")]
		public int Quantity = 1;

		public StockModel(Stock stock)
		{
			Stock = stock;
		}
	}
}
