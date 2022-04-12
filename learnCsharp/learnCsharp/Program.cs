using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
	internal class Program
	{
		public interface IFoo1
		{
			void Foo();
		}

		public class FooImpl1 : IFoo1 {
			public void Foo() => Console.WriteLine("ImplicitInterfaceImplementation.Foo");
		}






		static void Main(string[] args)
		{
			
		}
	}
}
