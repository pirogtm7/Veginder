﻿using DLL.Entities;
using DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly VeginderDbContext _context;
		public IRepository<AddressEntity> AddressRepository { get; }
		public IRepository<OrderEntity> OrderRepository { get; }
		public IRepository<ProductCategoryEntity> ProductCategoryRepository { get; }
		public IRepository<ProductEntity> ProductRepository { get; }
		public IRepository<ShopEntity> ShopRepository { get; }
		public IRepository<CartOrderItemEntity> CartOrderItemRepository { get; }
		public IRepository<StockEntity> StockRepository { get; }


		public UnitOfWork(VeginderDbContext context,
			IRepository<AddressEntity> addresses, IRepository<OrderEntity> orders, 
			IRepository<ProductEntity> products, IRepository<ShopEntity> shops,
			IRepository<CartOrderItemEntity> cartOrderItems,
			IRepository<StockEntity> stocks, IRepository<ProductCategoryEntity> categories)
		{
			_context = context;
			AddressRepository = addresses;
			OrderRepository = orders;
			ProductRepository = products;
			ShopRepository = shops;
			CartOrderItemRepository = cartOrderItems;
			StockRepository = stocks;
			ProductCategoryRepository = categories;
		}

		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
