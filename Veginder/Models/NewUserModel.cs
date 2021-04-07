﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
	public class NewUserModel
	{
		[Required]
		[Display(Name = "Full name")]
		public string FullName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password",
			ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }
	}
}
