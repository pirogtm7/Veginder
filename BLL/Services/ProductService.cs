using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DLL.Entities;
using DLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<Product> GetAllProducts()
		{
			IEnumerable<ProductEntity> productEntities = _unitOfWork.ProductRepository.GetAll();
			IEnumerable<Product> products = _mapper.Map<IEnumerable<Product>>(productEntities);
			return products;
		}
	}
}
