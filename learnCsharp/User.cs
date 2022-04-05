using System;

public class Student
{
		public string Name { get; set; }
		public int Age { get; set; }

		
		public Student()
		{
			Name = "a";
			Age = 5;
		}
		public Student(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string ToString(string name){
			return name;
		}
}
