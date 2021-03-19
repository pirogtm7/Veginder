using BLL.DTOs;
using DLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
	public class VeginderDbContext : IdentityDbContext<User>
	{
		public DbSet<CustomerEntity> CustomerContextEntities { get; set; }
		public DbSet<DeliveryEntity> DeliveryContextEntities { get; set; }
		public DbSet<CartEntity> CartContextEntities { get; set; }
		public DbSet<OrderEntity> OrderContextEntities { get; set; }
		public DbSet<PaymentEntity> PaymentContextEntities { get; set; }
		public DbSet<ProductEntity> ProductContextEntities { get; set; }
		public DbSet<ShopEntity> ShopContextEntities { get; set; }

		public VeginderDbContext(DbContextOptions<VeginderDbContext> options) : base(options)
		{
			//VeginderDbContext.Initialize(this);
		}
	}


}
