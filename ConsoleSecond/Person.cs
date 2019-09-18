﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecond
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public ShoppingCart ShoppingCart { get; set; }

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}