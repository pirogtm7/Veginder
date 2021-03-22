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
		private string fullName;

		public string FullName { get => fullName; set => fullName = value; }
	}
}
