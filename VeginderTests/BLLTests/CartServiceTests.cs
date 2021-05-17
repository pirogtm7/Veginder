using Autofac.Extras.Moq;
using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using BLL.Services;
using DAL.Entities;
using DAL.Repositories;
using DAL.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace VeginderTests.BLLTests
{
    [TestFixture]
    public class CartServiceTests
    {
		IMapper mapper;
		Mock<IUnitOfWork> mockUOF;
		ICartService cartService;
        #region data
        static ProductCategory dairy = new ProductCategory() { Name = "Dairy" };
		static Product cheese = new Product()
		{
			Id = 1, 
			Name = "Cheese",
			Description = "desc2",
			PicturePath = "https://drive.google.com/uc?id=1yUI_gGS0TZrpf_Dx7ricb8X9hJuY2gX3",
			Category = dairy
		};
		static Shop biobio = new Shop()
		{
			Id = 1,
			Name = "Bio&Bio",
			Description = "Lorem ipsum dolor sit amet",
			PicturePath = "https://drive.google.com/uc?id=1RUcT1Y3Kog5g6zOVbYoM4FxTz6Nqxqni",
			Address = "address1",
		};
		static Stock s = new Stock()
		{
			Id = 1,
			Price = 4,
			Quantity = 2,
			Shop = biobio,
			Product = cheese
		};		
		CartOrderItemEntity c = new CartOrderItemEntity()
		{
			Id = 1,
			StockId = 1,
			Quantity = 1,
			CartId = "4596490f-524f-4af2-bf72-16f15bd78831",
			Price = 4
		};
		static List<CartOrderItem> expectedfullList = new List<CartOrderItem>()
		{
			new CartOrderItem()
			{
				StockId = s.Id,
				Quantity = 1,
				CartId = "4596490f-524f-4af2-bf72-16f15bd78831",
				Price = 4
			},
			new CartOrderItem()
			{	
				StockId = 2,
				Quantity = 1,
				CartId = "4596490f-524f-4af2-bf72-16f15bd78831",
				Price = 5
			}
		};
		List<CartOrderItemEntity> entities;
		static Order order = new Order()
		{
			Id = 1,
			Email = "lalala@gmail.com",
			TotalAmount = expectedfullList[0].Price+expectedfullList[1].Price,
			OrderStatusId = 0
		};
		#endregion

		[SetUp]
		public void SetUp()
        {
			var mapperConfig = new MapperConfiguration(
				  opts => opts.CreateMap<CartOrderItem, CartOrderItemEntity>().ReverseMap());

			mapper = mapperConfig.CreateMapper();

			entities = mapper.Map<List<CartOrderItemEntity>>(expectedfullList);

			mockUOF = new Mock<IUnitOfWork>();
			mockUOF.Setup(x => x.CartOrderItemRepository.GetAll())
				.Returns(entities);

			cartService = new CartService(mockUOF.Object, mapper);
		}


		[Test]
		public void AddItemToCart_NoItemInCart_ItemAdded()
		{
			//Arrange
			var expectedDTO = new List<CartOrderItem>();
			var expectedEntities = mapper.Map<List<CartOrderItemEntity>>(expectedDTO);
			var mockUOF = new Mock<IUnitOfWork>();
			mockUOF.Setup(x => x.CartOrderItemRepository.Add(c)).Verifiable();
			mockUOF.Setup(x => x.StockRepository.Get(c.StockId)).Returns(mapper.Map<StockEntity>(s));

            cartService = new CartService(mockUOF.Object, mapper);

			//Act
			cartService.AddItemToCart(s, 1, "4596490f-524f-4af2-bf72-16f15bd78831");

			//Assert
			mockUOF.Verify(x => x.CartOrderItemRepository.Add(c), Times.Once);
		}

		[Test]
		public void GetAllItemsFromCart_IdCartPassed_ListOfItemsReturned()
		{
			//arrange

			//act
			var actual = cartService.GetAllItemsFromCart("4596490f-524f-4af2-bf72-16f15bd78831");

			//Assert
			Assert.True(actual != null);
			Assert.AreEqual(expectedfullList.Count, actual.Count);

			for(int i=0; i<expectedfullList.Count; i++)
            {
				Assert.AreEqual(expectedfullList[0].Price, actual[0].Price);
            }

		}

		[TestCase("4596490f-524f-4af2-bf72-16f15bd78831")]//pass
		//[TestCase(null)]//fail
		public void CountTotalAmount_IdCartPassed_TotalAmountReturned(string? cartId)
        {
			//arrange
			var expected = expectedfullList[0].Price * expectedfullList[0].Quantity + 
						   expectedfullList[1].Price * expectedfullList[1].Quantity;//9

			//act
			var actual = cartService.CountTotalAmount(cartId);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void UpdateCartId_NewCartIdPassed_ItemsUpdated()
        {
			//arrange
			var oldId = expectedfullList[0].CartId;
			var newId = "bla";

			//act
			cartService.UpdateCartId(oldId, newId);

			//assert

			mockUOF.Verify(x => x.CartOrderItemRepository.Update(entities[0]), Times.Once);
			mockUOF.Verify(x => x.Save(), Times.Exactly(entities.Count));
        }

		[Test]
		public void SetOrderId_OrderIDPassed_ItemsUpdated()
        {
			//arrange
			var cartId = expectedfullList[0].CartId;
			var orderId = order.Id;

			//act
			cartService.SetOrderId(cartId, orderId);

			//assert
			for(int i=0; i<entities.Count; i++)
            {
				mockUOF.Verify(x => x.CartOrderItemRepository.Update(entities[0]), Times.Once);
            }
			mockUOF.Verify(x => x.Save(), Times.Exactly(entities.Count));
		}
	}
}
