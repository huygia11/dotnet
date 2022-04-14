using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenuConsoleApp
{
	internal class Student
	{
		public int id { get; set; }
		public string name { get; set; }

		public Student(int sId, string sName) {
			this.id = sId;
			this.name = sName;
		}

	}
}
