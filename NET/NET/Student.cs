using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET
{
	internal class Student
	{
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }

		public Student() {
			id = 1;
			name = "huy";
			age = 22;
		}

		public Student(int sId, string sName, int sAge)
		{
			id = sId;
			name = sName;
			age = sAge;
		}

		Student[] studentList = new Student[] {};

	}
}
