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
		public DbSet<AddressEntity> Addresses { get; set; }
		public DbSet<OrderEntity> Orders { get; set; }
		public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<ShopEntity> Shops { get; set; }
		public DbSet<CartOrderItemEntity> CartOrderItems { get; set; }
		public DbSet<StockEntity> Stocks { get; set; }


		public VeginderDbContext(DbContextOptions<VeginderDbContext> options) : base(options)
		{
			VeginderDbInitializer.Initialize(this);
		}
	}
}
