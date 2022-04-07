using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
	internal class Pig : Animal, IAnimal, IAnimal2
	{
		public override void animalSound() {
			Console.WriteLine("ec ec");
		}
		public void move() {
			Console.WriteLine("4 chan");
		}

		public void sleep() {
			Console.WriteLine("kho kho");
		}
	}
}
