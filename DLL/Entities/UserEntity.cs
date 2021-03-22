using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class UserEntity : IdentityUser
	{
		[Required]
		private string _fullName;

		public string FullName { get => _fullName; set => _fullName = value; }
	}
}
