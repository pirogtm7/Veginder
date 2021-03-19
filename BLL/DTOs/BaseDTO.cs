using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public abstract class BaseDTO
	{
		private int id;

		public int Id { get => id; set => id = value; }
	}
}
