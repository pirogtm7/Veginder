﻿using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface ICategoryService
	{
		IEnumerable<ProductCategory> GetAllCategories();
	}
}
