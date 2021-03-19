using DLL.Entities;
using DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly VeginderDbContext context;
		public IRepository<CustomerEntity> CustomerRepository { get; }
		public IRepository<DeliveryEntity> DeliveryRepository { get; }
		public IRepository<CartEntity> CartRepository { get; }
		public IRepository<OrderEntity> OrderRepository { get; }
		public IRepository<PaymentEntity> PaymentRepository { get; }
		public IRepository<ProductEntity> ProductRepository { get; }
		public IRepository<ShopEntity> ShopRepository { get; }


		public UnitOfWork(VeginderDbContext context, IRepository<CustomerEntity> customers,
			IRepository<DeliveryEntity> deliveries,	IRepository<CartEntity> carts,
			IRepository<OrderEntity> orders, IRepository<PaymentEntity> payments,
			IRepository<ProductEntity> products, IRepository<ShopEntity> shops)
		{
			this.context = context;
			CustomerRepository = customers;
			DeliveryRepository = deliveries;
			CartRepository = carts;
			OrderRepository = orders;
			PaymentRepository = payments;
			ProductRepository = products;
			ShopRepository = shops;
		}

		public void Save()
		{
			context.SaveChanges();
		}
	}
}
