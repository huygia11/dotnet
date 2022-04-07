using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
	abstract class Animal
	{
		// abstract method không có body
		public abstract void animalSound();

		public void sleep()
		{
			Console.WriteLine("zzz");
		}

	}
}
