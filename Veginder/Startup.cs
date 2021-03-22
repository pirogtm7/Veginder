using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Services;
using BLL.Interfaces;
using DLL;
using DLL.Entities;
using DLL.Repositories;
using DLL.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Veginder
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<VeginderDbContext>(opt =>
				opt.UseSqlServer(Configuration.GetConnectionString("VeginderDatabase")));
			services.AddScoped<IRepository<AddressEntity>, Repository<AddressEntity>>();
			services.AddScoped<IRepository<CartEntity>, Repository<CartEntity>>();
			services.AddScoped<IRepository<OrderEntity>, Repository<OrderEntity>>();
			services.AddScoped<IRepository<ProductCategoryEntity>, Repository<ProductCategoryEntity>>();
			services.AddScoped<IRepository<ProductEntity>, Repository<ProductEntity>>();
			services.AddScoped<IRepository<ShopEntity>, Repository<ShopEntity>>();
			services.AddScoped<IRepository<StockEntity>, Repository<StockEntity>>();
			services.AddScoped<IRepository<CartOrderItemEntity>, Repository<CartOrderItemEntity>>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddSingleton(new MapperConfiguration(c => c.AddProfile(new BLL.Mapper())).CreateMapper());
			services.AddTransient<IProductService, ProductService>();
			services.AddTransient<IShopService, ShopService>();
			services.AddTransient<ICategoryService, CategoryService>();

			services.AddIdentity<UserEntity, IdentityRole>(options => options.SignIn.RequireConfirmedEmail = false)
					.AddEntityFrameworkStores<VeginderDbContext>()
					.AddDefaultTokenProviders();

			services.AddControllersWithViews();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
