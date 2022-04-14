using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	internal class Program
	{

		class Animal {
			public virtual void animalSound() {
				Console.WriteLine("animal sound");
			}
		}

		class Pig : Animal {
			public override void animalSound() {
				Console.WriteLine("Pig sound ec ec ec");
			}
		}

		class Dog : Animal {
			public void animalSound() {
				Console.WriteLine("Dog sound gau gau gau");
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			Animal animal = new Animal();
			Animal pig = new Pig();
			Animal dog = new Dog();

			animal.animalSound();
			pig.animalSound();
			dog.animalSound();
		}

		

		
	}
}
