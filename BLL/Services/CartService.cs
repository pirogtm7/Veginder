using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
	public class CartService : ICartService
	{
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public CartService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public void AddItemToCart(CartOrderItem item)
		{
			CartOrderItemEntity itemEntity = _mapper.Map<CartOrderItemEntity>(item);
			_unitOfWork.CartOrderItemRepository.Add(itemEntity);
			_unitOfWork.Save();
		}

		public List<CartOrderItem> GetAllItemsFromCart(string cartId)
		{
			IEnumerable<CartOrderItemEntity> itemEntities = _unitOfWork.CartOrderItemRepository.GetAll();
			List<CartOrderItemEntity> sortedItemEntities = new List<CartOrderItemEntity>();
			foreach (CartOrderItemEntity i in itemEntities)
			{
				if (i.CartId == cartId)
				{
					sortedItemEntities.Add(i);
				}
			}

			return _mapper.Map<List<CartOrderItem>>(sortedItemEntities);
		}
	}
}
