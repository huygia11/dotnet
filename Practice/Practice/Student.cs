using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Student
	{
		public string name { get; set; }
		public int age { get; set; }

		public Student(string sName, int sAge) {
			name = sName;
			age = sAge;
		}

		public Student() {
			name = "huy";
			age = 22;
		}

		static void Main(string[] args)
		{
			Student student = new Student("huy ", 22);
			Student student2 = new Student("huy2 ", 22);
			Student student3 = new Student("huy3 ", 22);
			
			Student[] sList = new Student[3] {new Student("Duy",20), new Student("Duy2", 20), new Student("Duy3", 20)};
			
			List<Student> students = new List<Student>() { new Student("Duy", 20), new Student("Duy2", 20), new Student("Duy3", 20) };

			students.Add(student);
			var exist = students.FirstOrDefault(a => a.name == "Duy");

		}
	}
}
