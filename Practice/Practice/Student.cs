﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Student
	{
		public int id { get; set; }
		public string name { get; set; }

		public Student() {
			id = 1;
			name = "huy";
		}

		public Student(int sId, string sName) {
			id = sId;
			name = sName;
		}

		public void showInfo() {
			Console.WriteLine($"Id: {id} | Name: {name}");
		}

	}
}