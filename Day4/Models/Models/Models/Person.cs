﻿using Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Models
{
	public class Person
	{
		public int PersonId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Address HomeAddress { get; set; }
		public Role Role { get; set; }
	}
    //[ModelBinder(typeof(CustomModelBinder))] -- чтобы не регестрирвоать в глобал асаксе
	public class Address
	{
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
	}

	public enum Role
	{
		Admin,
		User,
		Guest
	}
}