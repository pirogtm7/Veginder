using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface IStockService
	{
		IEnumerable<Stock> GetAllStocks();
		Stock GetStockById(int id);
	}
}
