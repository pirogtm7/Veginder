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
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<ProductCategory> GetAllCategories()
		{
			IEnumerable<ProductCategoryEntity> categEntities = _unitOfWork.ProductCategoryRepository.GetAll();
			return _mapper.Map<IEnumerable<ProductCategory>>(categEntities);
		}
	}
}
