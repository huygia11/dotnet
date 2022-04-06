using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET
{
	class Program
	{
		static void Main(string[] args) {
			Student s1 = new Student(1, "huy", 22);
			Student s2 = new Student(2, "huy2", 23);
			Student s3 = new Student(3, "huy3", 23);

			Person p1 = new Person();
			p1.Name = "huy";
			Console.WriteLine(p1.Name);
		}
	}
}