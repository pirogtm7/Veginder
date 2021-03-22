using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
	public class VeginderDbInitializer
	{
		private static bool initialized = false;
		public static void Initialize(VeginderDbContext context)
		{
			if (initialized)
			{
				return;
			}

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
			//if (!context.Database.EnsureCreated())
			//{
			//	return;
			//}

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
				Price = 30,
				Category = dairy
			};

			ProductEntity cheese = new ProductEntity()
			{
				Name = "Cheese",
				Description = "desc2",
				PicturePath = "https://drive.google.com/uc?id=1yUI_gGS0TZrpf_Dx7ricb8X9hJuY2gX3",
				Price = 20,
				Category = dairy
			};

			ProductEntity milk = new ProductEntity()
			{
				Name = "Milk",
				Description = "desc3",
				PicturePath = "https://drive.google.com/uc?id=1LOxpSdvhBtB4uQt3ApQVCukom5TYSInC",
				Price = 18,
				Category = dairy
			};

			ProductEntity yogurt = new ProductEntity()
			{
				Name = "Yogurt",
				Description = "desc4",
				PicturePath = "https://drive.google.com/uc?id=1PrMFedgUNk_9olAk5o84LIvUDadRE8he",
				Price = 50,
				Category = dairy
			};

			ProductEntity juice = new ProductEntity()
			{
				Name = "Juice",
				Description = "desc5",
				PicturePath = "https://drive.google.com/uc?id=1btz472A-lz84VFlXggOoOVOzlBWMuVaK",
				Price = 32,
				Category = drinks
			};

			ProductEntity tea = new ProductEntity()
			{
				Name = "Tea",
				Description = "desc6",
				PicturePath = "https://drive.google.com/uc?id=1tuL4WCp6pCiCVzM4ygLTH9qe2GEy_sUh",
				Price = 12,
				Category = drinks
			};

			ProductEntity water = new ProductEntity()
			{
				Name = "Water",
				Description = "desc7",
				PicturePath = "https://drive.google.com/uc?id=1jgvJm4UytWVDEvGqX3P21sUmD7AaBivO",
				Price = 20,
				Category = drinks
			};

			ProductEntity dorado = new ProductEntity()
			{
				Name = "Dorado",
				Description = "desc8",
				PicturePath = "https://drive.google.com/uc?id=1onhGzjCFlEkZNhpDlyBTRH6YkaKwu9Zm",
				Price = 50,
				Category = fish
			};

			ProductEntity bananas = new ProductEntity()
			{
				Name = "Bananas",
				Description = "desc9",
				PicturePath = "https://drive.google.com/uc?id=1LfWuory-YXoGLAOFU6-gpBZ8vqtOxwAt",
				Price = 22,
				Category = fruits
			};

			ProductEntity kiwi = new ProductEntity()
			{
				Name = "Kiwi",
				Description = "desc10",
				PicturePath = "https://drive.google.com/uc?id=1-bx44bBANzjW5J2qwacRFlCUs_qZZmsG",
				Price = 42,
				Category = fruits
			};

			ProductEntity pears = new ProductEntity()
			{
				Name = "Pears",
				Description = "desc11",
				PicturePath = "https://drive.google.com/uc?id=1O58FeP1pqV-CyjW9uy-J0q0mCogxMt0I",
				Price = 19,
				Category = fruits
			};

			ProductEntity flour = new ProductEntity()
			{
				Name = "Flour",
				Description = "desc12",
				PicturePath = "https://drive.google.com/uc?id=1TQQPbw6bOVlWQMg7OA6Hvh36FRy_jvUt",
				Price = 31,
				Category = grocery
			};

			ProductEntity oatmeal = new ProductEntity()
			{
				Name = "Oatmeal",
				Description = "desc13",
				PicturePath = "https://drive.google.com/uc?id=1oMYUoRs1I6A6IWZlADhq8aqxzY5W5U7H",
				Price = 21,
				Category = grocery
			};

			ProductEntity oliveoil = new ProductEntity()
			{
				Name = "Olive Oil",
				Description = "desc14",
				PicturePath = "https://drive.google.com/uc?id=1DKOyI4c5Pix023p6MCWo00O6hC-nWlkb",
				Price = 40,
				Category = grocery
			};

			ProductEntity beef = new ProductEntity()
			{
				Name = "Beef",
				Description = "desc15",
				PicturePath = "https://drive.google.com/uc?id=1g-wiFd1Gt6EcUlIm1DWDor7zw_Z-3aFg",
				Price = 36,
				Category = meat
			};

			ProductEntity pork = new ProductEntity()
			{
				Name = "Pork",
				Description = "desc16",
				PicturePath = "https://drive.google.com/uc?id=1Ccd_sLNmHZc4a7zyfz7anopHgfmgOf30",
				Price = 37,
				Category = meat
			};

			ProductEntity salo = new ProductEntity()
			{
				Name = "Salo",
				Description = "desc17",
				PicturePath = "https://drive.google.com/uc?id=1CVa_nb0cOGMC0gtyOBbeFuwo9bh60hkT",
				Price = 1000,
				Category = meat
			};

			ProductEntity biscuits = new ProductEntity()
			{
				Name = "Biscuits",
				Description = "desc18",
				PicturePath = "https://drive.google.com/uc?id=1gZhecY6Ubd6h29nVaMpKZ6vQCC0maoJ3",
				Price = 20,
				Category = sweets
			};

			ProductEntity peanutbutter = new ProductEntity()
			{
				Name = "Peanut Butter",
				Description = "desc19",
				PicturePath = "https://drive.google.com/uc?id=1CfIxkIKC0gaip5FUsCVUTBlTzMHrrKxf",
				Price = 35,
				Category = sweets
			};

			ProductEntity avocado = new ProductEntity()
			{
				Name = "Avocado",
				Description = "desc20",
				PicturePath = "https://drive.google.com/uc?id=1SJrNlF00UHSwli6TDaKyNLkDYtKmwhRW",
				Price = 40,
				Category = vegetables
			};

			ProductEntity bellpepper = new ProductEntity()
			{
				Name = "Bell Pepper",
				Description = "desc21",
				PicturePath = "https://drive.google.com/uc?id=1BZKsZveiNwh2HX5WVLylHW0Sjq8YsDAl",
				Price = 30,
				Category = vegetables
			};

			ProductEntity potato = new ProductEntity()
			{
				Name = "Potato",
				Description = "desc22",
				PicturePath = "https://drive.google.com/uc?id=1SWYTqxi9O0DnhyAVjyPrX8Wvh7agJZjz",
				Price = 30,
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
				Quantity = 20
			};

			StockEntity biobio2 = new StockEntity()
			{
				Shop = biobio,
				Product = tea,
				Quantity = 30
			};

			StockEntity biobio3 = new StockEntity()
			{
				Shop = biobio,
				Product = juice,
				Quantity = 20
			};

			StockEntity biobio4 = new StockEntity()
			{
				Shop = biobio,
				Product = dorado,
				Quantity = 20
			};

			StockEntity biobio5 = new StockEntity()
			{
				Shop = biobio,
				Product = bananas,
				Quantity = 20
			};

			StockEntity biobio6 = new StockEntity()
			{
				Shop = biobio,
				Product = kiwi,
				Quantity = 20
			};

			StockEntity biobio7 = new StockEntity()
			{
				Shop = biobio,
				Product = pears,
				Quantity = 20
			};

			StockEntity biobio8 = new StockEntity()
			{
				Shop = biobio,
				Product = flour,
				Quantity = 20
			};

			StockEntity biobio9 = new StockEntity()
			{
				Shop = biobio,
				Product = oatmeal,
				Quantity = 20
			};

			StockEntity biobio10 = new StockEntity()
			{
				Shop = biobio,
				Product = oliveoil,
				Quantity = 20
			};

			StockEntity biobio11 = new StockEntity()
			{
				Shop = biobio,
				Product = beef,
				Quantity = 20
			};

			StockEntity biobio12 = new StockEntity()
			{
				Shop = biobio,
				Product = pork,
				Quantity = 20
			};

			StockEntity biobio13 = new StockEntity()
			{
				Shop = biobio,
				Product = salo,
				Quantity = 20
			};

			StockEntity biomatica1 = new StockEntity()
			{
				Shop = biomatica,
				Product = biscuits,
				Quantity = 20
			};

			StockEntity biomatica2 = new StockEntity()
			{
				Shop = biomatica,
				Product = peanutbutter,
				Quantity = 20
			};

			StockEntity biomatica3 = new StockEntity()
			{
				Shop = biomatica,
				Product = avocado,
				Quantity = 20
			};

			StockEntity biomatica4 = new StockEntity()
			{
				Shop = biomatica,
				Product = bellpepper,
				Quantity = 20
			};

			StockEntity biomatica5 = new StockEntity()
			{
				Shop = biomatica,
				Product = potato,
				Quantity = 20
			};


			StockEntity biomatica6 = new StockEntity()
			{
				Shop = biomatica,
				Product = dorado,
				Quantity = 20
			};

			StockEntity biomatica7 = new StockEntity()
			{
				Shop = biomatica,
				Product = oatmeal,
				Quantity = 20
			};

			StockEntity biomatica8 = new StockEntity()
			{
				Shop = biomatica,
				Product = oliveoil,
				Quantity = 20
			};

			StockEntity greencommon1 = new StockEntity()
			{
				Shop = greencommon,
				Product = blamblamble,
				Quantity = 20
			};

			StockEntity greencommon2 = new StockEntity()
			{
				Shop = greencommon,
				Product = milk,
				Quantity = 20
			};

			StockEntity greencommon3 = new StockEntity()
			{
				Shop = greencommon,
				Product = yogurt,
				Quantity = 20
			};

			StockEntity greencommon4 = new StockEntity()
			{
				Shop = greencommon,
				Product = water,
				Quantity = 20
			};

			StockEntity greencommon5 = new StockEntity()
			{
				Shop = greencommon,
				Product = beef,
				Quantity = 20
			};

			StockEntity greencommon6 = new StockEntity()
			{
				Shop = greencommon,
				Product = biscuits,
				Quantity = 20
			};

			StockEntity greencommon7 = new StockEntity()
			{
				Shop = greencommon,
				Product = potato,
				Quantity = 20
			};

			context.ShopContextEntities.Add(pur);

			context.StockContextEntities.AddRange(new List<StockEntity> {biobio1, biobio2, biobio3, biobio4, biobio5, biobio6,
				biobio7, biobio8, biobio9, biobio10, biobio11, biobio12, biobio13, biomatica1, biomatica2, biomatica3,
				biomatica4, biomatica5, biomatica6, biomatica7, biomatica8, greencommon1, greencommon2, greencommon3,
				greencommon4, greencommon5, greencommon6, greencommon7});

			context.SaveChanges();

			initialized = true;
		}
	}
}
