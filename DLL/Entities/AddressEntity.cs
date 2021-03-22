using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class AddressEntity : BaseEntity
	{
		[Required]
		private string _fullName;
		[Required]
		private string _street;
		[Required]
		private string _city;
		[Required]
		private int _zip;
		public string FullName { get => _fullName; set => _fullName = value; }
		public string Street { get => _street; set => _street = value; }
		public string City { get => _city; set => _city = value; }
		public int Zip { get => _zip; set => _zip = value; }

		public AddressEntity(string fullName)
		{
			_fullName = fullName;
		}
	}
}
