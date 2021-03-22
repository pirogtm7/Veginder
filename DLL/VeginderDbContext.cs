using DLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
	public class VeginderDbContext : IdentityDbContext<UserEntity>
	{
		public DbSet<AddressEntity> DeliveryContextEntities { get; set; }
		public DbSet<CartEntity> CartContextEntities { get; set; }
		public DbSet<OrderEntity> OrderContextEntities { get; set; }
		public DbSet<ProductCategoryEntity> ProductCategoryContextEntities { get; set; }
		public DbSet<ProductEntity> ProductContextEntities { get; set; }
		public DbSet<ShopEntity> ShopContextEntities { get; set; }
		public DbSet<CartOrderItemEntity> CartOrderItemContextEntities { get; set; }
		public DbSet<StockEntity> StockContextEntities { get; set; }


		public VeginderDbContext(DbContextOptions<VeginderDbContext> options) : base(options)
		{
			//VeginderDbInitializer.Initialize(this);
		}
	}


}
