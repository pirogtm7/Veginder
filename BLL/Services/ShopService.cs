using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
	public class ShopService : IShopService
	{
		private readonly IUnitOfWork UnitOfWork;
		IMapper mapper;

		public ShopService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			UnitOfWork = unitOfWork;
			this.mapper = mapper;
		}

		public IEnumerable<Shop> GetAllShops()
		{
			var shopEntities = UnitOfWork.ShopRepository.GetAll();
			var shops = mapper.Map<IEnumerable<Shop>>(shopEntities);
			return shops;
		}
	}
}
