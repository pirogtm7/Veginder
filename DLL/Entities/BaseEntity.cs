﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public abstract class BaseEntity : IBaseEntity
	{
		private int _id;
		[Required]
		public int Id { get => _id; set => _id = value; }
	}
}
