using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pig pig = new Pig();

			IAnimal newPig = new Pig();

			pig.move();

			newPig.move();
			
		}
	}
}
