using DLL.Entities;
using DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.UnitOfWork
{
	public interface IUnitOfWork
	{
		IRepository<AddressEntity> DeliveryRepository { get; }
		IRepository<CartEntity> CartRepository { get; }
		IRepository<OrderEntity> OrderRepository { get; }
		IRepository<ProductEntity> ProductRepository { get; }
		IRepository<ShopEntity> ShopRepository { get; }

		void Save();
	}
}
