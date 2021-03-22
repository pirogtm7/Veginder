using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork UnitOfWork;
		IMapper mapper;

		public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			UnitOfWork = unitOfWork;
			this.mapper = mapper;
		}

		public IEnumerable<Product> GetAllProducts()
		{
			var productEntities = UnitOfWork.ProductRepository.GetAll();
			var products = mapper.Map<IEnumerable<Product>>(productEntities);
			return products;
		}
	}
}
