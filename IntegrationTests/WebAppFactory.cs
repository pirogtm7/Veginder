using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using VeginderAPI;

namespace IntegrationTests
{
    internal class WebAppFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                RemoveShopDbContextRegistration(services);

                var serviceProvider = GetInMemoryServiceProvider();

                services.AddDbContextPool<VeginderDbContext>(options =>
                {
                    options.UseInMemoryDatabase(Guid.Empty.ToString());
                    options.UseInternalServiceProvider(serviceProvider);
                });

                using var scope = services.BuildServiceProvider().CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<VeginderDbContext>();

                InitData(context);
            });
        }

        private void InitData(VeginderDbContext context)
        {
			OrderStatusEntity pending = new OrderStatusEntity() { Name = "Pending" };
			OrderStatusEntity paymentReceived = new OrderStatusEntity() { Name = "Payment received" };
			OrderStatusEntity paymentFailed = new OrderStatusEntity() { Name = "Payment failed" };
			OrderStatusEntity sent = new OrderStatusEntity() { Name = "Sent" };
			OrderStatusEntity delivered = new OrderStatusEntity() { Name = "Delivered" };


			ProductCategoryEntity dairy = new ProductCategoryEntity() { Name = "Dairy" };
			ProductCategoryEntity drinks = new ProductCategoryEntity() { Name = "Drinks" };
			ProductCategoryEntity fish = new ProductCategoryEntity() { Name = "Fish" };
			ProductCategoryEntity fruits = new ProductCategoryEntity() { Name = "Fruits" };
			ProductCategoryEntity grocery = new ProductCategoryEntity() { Name = "Grocery" };
			ProductCategoryEntity meat = new ProductCategoryEntity() { Name = "Meat" };
			ProductCategoryEntity sweets = new ProductCategoryEntity() { Name = "Sweets" };
			ProductCategoryEntity vegetables = new ProductCategoryEntity() { Name = "Vegetables" };



			ProductEntity blamblamble = new ProductEntity()
			{
				Name = "Blam Blam Ble",
				Description = "desc1",
				PicturePath = "https://drive.google.com/uc?id=1J1U9zCfBr5VFohWbsk1GuU7tBSkPFaYG",
				Category = dairy
			};

			ProductEntity cheese = new ProductEntity()
			{
				Name = "Cheese",
				Description = "desc2",
				PicturePath = "https://drive.google.com/uc?id=1yUI_gGS0TZrpf_Dx7ricb8X9hJuY2gX3",
				Category = dairy
			};

			ProductEntity milk = new ProductEntity()
			{
				Name = "Milk",
				Description = "desc3",
				PicturePath = "https://drive.google.com/uc?id=1LOxpSdvhBtB4uQt3ApQVCukom5TYSInC",
				Category = dairy
			};

			ProductEntity yogurt = new ProductEntity()
			{
				Name = "Yogurt",
				Description = "desc4",
				PicturePath = "https://drive.google.com/uc?id=1PrMFedgUNk_9olAk5o84LIvUDadRE8he",
				Category = dairy
			};

			ProductEntity juice = new ProductEntity()
			{
				Name = "Juice",
				Description = "desc5",
				PicturePath = "https://drive.google.com/uc?id=1btz472A-lz84VFlXggOoOVOzlBWMuVaK",
				Category = drinks
			};

			ProductEntity tea = new ProductEntity()
			{
				Name = "Tea",
				Description = "desc6",
				PicturePath = "https://drive.google.com/uc?id=1tuL4WCp6pCiCVzM4ygLTH9qe2GEy_sUh",
				Category = drinks
			};

			ProductEntity water = new ProductEntity()
			{
				Name = "Water",
				Description = "desc7",
				PicturePath = "https://drive.google.com/uc?id=1jgvJm4UytWVDEvGqX3P21sUmD7AaBivO",
				Category = drinks
			};

			ProductEntity dorado = new ProductEntity()
			{
				Name = "Dorado",
				Description = "desc8",
				PicturePath = "https://drive.google.com/uc?id=1onhGzjCFlEkZNhpDlyBTRH6YkaKwu9Zm",
				Category = fish
			};

			ProductEntity bananas = new ProductEntity()
			{
				Name = "Bananas",
				Description = "desc9",
				PicturePath = "https://drive.google.com/uc?id=1LfWuory-YXoGLAOFU6-gpBZ8vqtOxwAt",
				Category = fruits
			};

			ProductEntity kiwi = new ProductEntity()
			{
				Name = "Kiwi",
				Description = "desc10",
				PicturePath = "https://drive.google.com/uc?id=1-bx44bBANzjW5J2qwacRFlCUs_qZZmsG",
				Category = fruits
			};

			ProductEntity pears = new ProductEntity()
			{
				Name = "Pears",
				Description = "desc11",
				PicturePath = "https://drive.google.com/uc?id=1O58FeP1pqV-CyjW9uy-J0q0mCogxMt0I",
				Category = fruits
			};

			ProductEntity flour = new ProductEntity()
			{
				Name = "Flour",
				Description = "desc12",
				PicturePath = "https://drive.google.com/uc?id=1TQQPbw6bOVlWQMg7OA6Hvh36FRy_jvUt",
				Category = grocery
			};

			ProductEntity oatmeal = new ProductEntity()
			{
				Name = "Oatmeal",
				Description = "desc13",
				PicturePath = "https://drive.google.com/uc?id=1oMYUoRs1I6A6IWZlADhq8aqxzY5W5U7H",
				Category = grocery
			};

			ProductEntity oliveoil = new ProductEntity()
			{
				Name = "Olive Oil",
				Description = "desc14",
				PicturePath = "https://drive.google.com/uc?id=1DKOyI4c5Pix023p6MCWo00O6hC-nWlkb",
				Category = grocery
			};

			ProductEntity beef = new ProductEntity()
			{
				Name = "Beef",
				Description = "desc15",
				PicturePath = "https://drive.google.com/uc?id=1g-wiFd1Gt6EcUlIm1DWDor7zw_Z-3aFg",
				Category = meat
			};

			ProductEntity pork = new ProductEntity()
			{
				Name = "Pork",
				Description = "desc16",
				PicturePath = "https://drive.google.com/uc?id=1Ccd_sLNmHZc4a7zyfz7anopHgfmgOf30",
				Category = meat
			};

			ProductEntity salo = new ProductEntity()
			{
				Name = "Salo",
				Description = "desc17",
				PicturePath = "https://drive.google.com/uc?id=1CVa_nb0cOGMC0gtyOBbeFuwo9bh60hkT",
				Category = meat
			};

			ProductEntity biscuits = new ProductEntity()
			{
				Name = "Biscuits",
				Description = "desc18",
				PicturePath = "https://drive.google.com/uc?id=1gZhecY6Ubd6h29nVaMpKZ6vQCC0maoJ3",
				Category = sweets
			};

			ProductEntity peanutbutter = new ProductEntity()
			{
				Name = "Peanut Butter",
				Description = "desc19",
				PicturePath = "https://drive.google.com/uc?id=1CfIxkIKC0gaip5FUsCVUTBlTzMHrrKxf",
				Category = sweets
			};

			ProductEntity avocado = new ProductEntity()
			{
				Name = "Avocado",
				Description = "desc20",
				PicturePath = "https://drive.google.com/uc?id=1SJrNlF00UHSwli6TDaKyNLkDYtKmwhRW",
				Category = vegetables
			};

			ProductEntity bellpepper = new ProductEntity()
			{
				Name = "Bell Pepper",
				Description = "desc21",
				PicturePath = "https://drive.google.com/uc?id=1BZKsZveiNwh2HX5WVLylHW0Sjq8YsDAl",
				Category = vegetables
			};

			ProductEntity potato = new ProductEntity()
			{
				Name = "Potato",
				Description = "desc22",
				PicturePath = "https://drive.google.com/uc?id=1SWYTqxi9O0DnhyAVjyPrX8Wvh7agJZjz",
				Category = vegetables
			};

			ShopEntity biobio = new ShopEntity()
			{
				Name = "Bio&Bio",
				Description = "Lorem ipsum dolor sit amet",
				PicturePath = "https://drive.google.com/uc?id=1RUcT1Y3Kog5g6zOVbYoM4FxTz6Nqxqni",
				Address = "address1",
			};

			ShopEntity biomatica = new ShopEntity()
			{
				Name = "Biomatica",
				Description = "Lorem ipsum dolor sit amet",
				PicturePath = "https://drive.google.com/uc?id=15Q9fJDA4ZVbqxUomUmdzu6RZyaOG2YDe",
				Address = "address2",
			};

			ShopEntity greencommon = new ShopEntity()
			{
				Name = "Green Common",
				Description = "Lorem ipsum dolor sit amet",
				PicturePath = "https://drive.google.com/uc?id=1cfkI0E5HzYdojkrPvUgU7kksHRdSygqB",
				Address = "address3",
			};

			ShopEntity pur = new ShopEntity()
			{
				Name = "Pur",
				Description = "Lorem ipsum dolor sit amet",
				PicturePath = "https://drive.google.com/uc?id=1SyfffMBy0lem7VKpF03oNzQOGn8rmKlt",
				Address = "address4",
			};

			StockEntity biobio1 = new StockEntity()
			{
				Shop = biobio,
				Product = cheese,
				Price = 20,
				Quantity = 20
			};

			StockEntity biobio2 = new StockEntity()
			{
				Shop = biobio,
				Product = tea,
				Price = 21,
				Quantity = 30
			};

			StockEntity biobio3 = new StockEntity()
			{
				Shop = biobio,
				Product = juice,
				Price = 22,
				Quantity = 20
			};

			StockEntity biobio4 = new StockEntity()
			{
				Shop = biobio,
				Product = dorado,
				Price = 23,
				Quantity = 20
			};

			StockEntity biobio5 = new StockEntity()
			{
				Shop = biobio,
				Product = bananas,
				Price = 24,
				Quantity = 20
			};

			StockEntity biobio6 = new StockEntity()
			{
				Shop = biobio,
				Product = kiwi,
				Price = 25,
				Quantity = 20
			};

			StockEntity biobio7 = new StockEntity()
			{
				Shop = biobio,
				Product = pears,
				Price = 26,
				Quantity = 20
			};

			StockEntity biobio8 = new StockEntity()
			{
				Shop = biobio,
				Product = flour,
				Price = 27,
				Quantity = 20
			};

			StockEntity biobio9 = new StockEntity()
			{
				Shop = biobio,
				Product = oatmeal,
				Price = 27,
				Quantity = 20
			};

			StockEntity biobio10 = new StockEntity()
			{
				Shop = biobio,
				Product = oliveoil,
				Price = 28,
				Quantity = 20
			};

			StockEntity biobio11 = new StockEntity()
			{
				Shop = biobio,
				Product = beef,
				Price = 29,
				Quantity = 20
			};

			StockEntity biobio12 = new StockEntity()
			{
				Shop = biobio,
				Product = pork,
				Price = 30,
				Quantity = 20
			};

			StockEntity biobio13 = new StockEntity()
			{
				Shop = biobio,
				Product = salo,
				Price = 1000,
				Quantity = 20
			};

			StockEntity biomatica1 = new StockEntity()
			{
				Shop = biomatica,
				Product = biscuits,
				Price = 31,
				Quantity = 20
			};

			StockEntity biomatica2 = new StockEntity()
			{
				Shop = biomatica,
				Product = peanutbutter,
				Price = 32,
				Quantity = 20
			};

			StockEntity biomatica3 = new StockEntity()
			{
				Shop = biomatica,
				Product = avocado,
				Price = 33,
				Quantity = 20
			};

			StockEntity biomatica4 = new StockEntity()
			{
				Shop = biomatica,
				Product = bellpepper,
				Price = 34,
				Quantity = 3
			};

			StockEntity biomatica5 = new StockEntity()
			{
				Shop = biomatica,
				Product = potato,
				Price = 35,
				Quantity = 20
			};


			StockEntity biomatica6 = new StockEntity()
			{
				Shop = biomatica,
				Product = dorado,
				Price = 36,
				Quantity = 20
			};

			StockEntity biomatica7 = new StockEntity()
			{
				Shop = biomatica,
				Product = oatmeal,
				Price = 37,
				Quantity = 20
			};

			StockEntity biomatica8 = new StockEntity()
			{
				Shop = biomatica,
				Product = oliveoil,
				Price = 38,
				Quantity = 20
			};

			StockEntity greencommon1 = new StockEntity()
			{
				Shop = greencommon,
				Product = blamblamble,
				Price = 39,
				Quantity = 20
			};

			StockEntity greencommon2 = new StockEntity()
			{
				Shop = greencommon,
				Product = milk,
				Price = 40,
				Quantity = 20
			};

			StockEntity greencommon3 = new StockEntity()
			{
				Shop = greencommon,
				Product = yogurt,
				Price = 41,
				Quantity = 20
			};

			StockEntity greencommon4 = new StockEntity()
			{
				Shop = greencommon,
				Product = water,
				Price = 42,
				Quantity = 20
			};

			StockEntity greencommon5 = new StockEntity()
			{
				Shop = greencommon,
				Product = beef,
				Price = 43,
				Quantity = 20
			};

			StockEntity greencommon6 = new StockEntity()
			{
				Shop = greencommon,
				Product = biscuits,
				Price = 44,
				Quantity = 20
			};

			StockEntity greencommon7 = new StockEntity()
			{
				Shop = greencommon,
				Product = potato,
				Price = 666,
				Quantity = 20
			};

			context.OrderStatuses.AddRange(new List<OrderStatusEntity> { pending, paymentReceived, paymentFailed, sent, delivered });

			context.Shops.Add(pur);

			context.Stocks.AddRange(new List<StockEntity> {biobio1, biobio2, biobio3, biobio4, biobio5, biobio6,
				biobio7, biobio8, biobio9, biobio10, biobio11, biobio12, biobio13, biomatica1, biomatica2, biomatica3,
				biomatica4, biomatica5, biomatica6, biomatica7, biomatica8, greencommon1, greencommon2, greencommon3,
				greencommon4, greencommon5, greencommon6, greencommon7});

			context.CartOrderItems.Add(new CartOrderItemEntity() { Quantity = 3, CartId = "testId", Stock = greencommon3 });
			context.CartOrderItems.Add(new CartOrderItemEntity() { Quantity = 1, CartId = "testId", Stock = biobio11 });

			context.SaveChanges();
		}
        private static ServiceProvider GetInMemoryServiceProvider()
        {
            return new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
        }

        private static void RemoveShopDbContextRegistration(IServiceCollection services)
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                     typeof(DbContextOptions<VeginderDbContext>));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }
        }
    }
}