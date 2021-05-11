using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Interfaces;

namespace VeginderTests.BLLTests
{
	[TestClass]
	public class StockServiceTests
	{
		IStockService _stockService;
		public StockServiceTests(IStockService stockService)
		{
			_stockService = stockService;
		}

		[TestMethod]
		public void TestMethod1()
		{
			//Arrange
			int id = 0;

			//Act


			//Assure
			//Assert.
		}
	}
}
