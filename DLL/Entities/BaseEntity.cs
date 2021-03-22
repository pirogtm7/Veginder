using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public abstract class BaseEntity : IBaseEntity
	{
		[Required]
		public int Id { get; set; }

	}
}
