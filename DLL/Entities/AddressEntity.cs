using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DLL.Entities
{
	public class AddressEntity : BaseEntity
	{
		[Required]
		private string fullName;
		[Required]
		private string street;
		[Required]
		private string city;
		[Required]
		private int zip;
		public string FullName { get => fullName; set => fullName = value; }
		public string Street { get => street; set => street = value; }
		public string City { get => city; set => city = value; }
		public int Zip { get => zip; set => zip = value; }

		public AddressEntity(string fullName)
		{
			this.fullName = fullName;
		}
	}
}
