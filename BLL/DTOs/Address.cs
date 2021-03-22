using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class Address : BaseDTO
	{
		private string fullName;
		private string street;
		private string city;
		private int zip;

		public string FullName { get => fullName; set => fullName = value; }
		public string Street { get => street; set => street = value; }
		public string City { get => city; set => city = value; }
		public int Zip { get => zip; set => zip = value; }
	}
}
