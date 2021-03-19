﻿using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Repositories
{
	public interface IRepository<TEntity> where TEntity : IBaseEntity
	{
		IEnumerable<TEntity> GetAll();
		void Add(TEntity entity);
		TEntity Get(int id);
		void Update(TEntity entity);
		void Delete(int id);
	}
}
