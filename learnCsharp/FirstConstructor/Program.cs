using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConstructor
{
	internal class Car
	{
		public string model { get; set; }// create a field
		public int price { get; set; }
		public Car() //create a class constructor for the Car class
		{
			model = "mustang";
			price = 100;
		}
		public void setModel(string model){
			this.model = model;
		}
		public string getModel(){
			return model;
		}
		static void Main(string[] args)
		{
			Car Ford = new Car();
			Console.WriteLine(Ford.model);
			Car BMW = new Car("new model", 200);
		}

		public Car(string model,int price) {
			this.model = model;
			this.price = price;
		}

		/*
		Note that the constructor name must match the class name, and it cannot have a return type (like void or int).

		Also note that the constructor is called when the object is created.

		All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.

		Constructors save time! Take a look at the last example on this page to really understand why.
		 */
	}
}
