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
	public class ShopService : IShopService
	{
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public ShopService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<Shop> GetAllShops()
		{
			IEnumerable<ShopEntity> shopEntities = _unitOfWork.ShopRepository.GetAll();
			IEnumerable<Shop> shops = _mapper.Map<IEnumerable<Shop>>(shopEntities);
			return shops;
		}
	}
}
