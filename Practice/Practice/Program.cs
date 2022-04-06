using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student(1, "huy");
			Student student2 = new Student(2, "duy");

			//student1.showInfo();
			//student2.showInfo();

			// create Array
			Student[] students = new Student[] { new Student(1, "huy"), new Student(2, "khang") };

			// create List
			List<Student> Lstudents = new List<Student>() { new Student(1, "huy"), new Student(2, "khang") };

			Console.WriteLine("so phan tu ban dau la: {0}", Lstudents.Count);

			Lstudents.Add(new Student(3, "duy 1"));
			Lstudents.Add(new Student(4, "duy 2"));
			Lstudents.Add(new Student(5, "duy 3"));
			Lstudents.Add(new Student(6, "duy 4"));
			Lstudents.Add(new Student(7, "truong 1"));
			Lstudents.Add(new Student(8, "truong 2"));
			Lstudents.Add(new Student(9, "truong 3"));

			Console.WriteLine("so luong phan tu trong list la: {0}", Lstudents.Count);




			/*
				SHOW LIST SAU KHI UPDATE ABC => DEF
			 */
			for (int i = 0; i < Lstudents.Count; i++)
			{
				if (Lstudents[i].name == "duy 1")
				{
					var std = Lstudents[i];
					std.name = "Duy Hut Thu";
					//Lstudents.Remove(std);
					//Lstudents.Add(std);
				}
			}

			// show list sau khi xoa phan tu co ten abc
			for (int i = 0; i < Lstudents.Count; i++)
			{
				var std = Lstudents[i];
				if (std.name == "duy 2")
				{
					Lstudents.Remove(std);
				}
			}



			foreach (Student s in Lstudents)
			{
				s.showInfo();
			}



			/*
				Hiển thị học sinh có tên chứa từ "duy"

				1- lấy ra được một DS student có tên chứa "Duy"
				

				2- In ra danh sach do.
			*/

			var listSDuy = new List<Student>() { };
			// Dùng foreach
			foreach (var item in Lstudents)
			{
				if (item.name.Contains("duy"))
				{
					listSDuy.Add(item);
					item.showInfo();
				}
			}

			// Dùng for
			var listDuyFor = new List<Student>() { };
			for (int i = 0; i < Lstudents.Count; i++)
			{
				var std = Lstudents[i];
				if (std.name.Contains("duy"))
				{
					listDuyFor.Add(std);
					std.showInfo();
				}
			}

			Console.ReadLine();
		}

	}
}
