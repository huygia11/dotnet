using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Models
{
	public class Student
	{
		private Guid Id { get; set; }
		private string Name { get; set; }
		private int Age { get; set; }

	}

	public class StudentViewModel
	{
		private string Name { get; set; }
		private int Age { get; set; }

	}
}