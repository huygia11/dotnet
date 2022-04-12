// See https://aka.ms/new-console-template for more 

static void Main(string[] args)
{

	string[] cars = { "ronaldo", "africa", "ricardo", "universal" };
	cars[2] = "Lamborghini";
	Console.WriteLine(cars[2]);
	Console.WriteLine(cars.Length);

	for (int i = 0; i < cars.Length; i++)
	{
		Console.WriteLine(cars[i]);
	}
	Console.WriteLine(cars.Length);

	//or foreach
	foreach (string i in cars)
	{
		Console.WriteLine(i);
	}

	Array.Sort(cars);
	foreach (string i in cars)
	{
		Console.WriteLine();
	}


	int[] numbers = { 1, 2, 3, 4, 5 };
	Array.Sort(numbers);
	foreach (int i in numbers)
	{
		Console.WriteLine(i);
	}

	//declare an array
	string[] trees;
	trees = new string[] { "quyt", "tao", "oi", "xoai" };
	trees[0] = "cay mận";

	void myMethod()
	{
		Console.WriteLine("i just got a new");
	}
	myMethod();

	void myMethod2(string fname)
	{
		Console.WriteLine(fname + "Universal");
	}

	myMethod2("Good Way ");
	myMethod2("Terrible Way ");

	// default parameter value
	void myMethod3(string country = "qncity")
	{
		Console.WriteLine(country);
	}
	myMethod3("qnhon");
	myMethod3("qngai");
	myMethod3();




	string[] array = { "huyngu", "khanghandsomeboy", "huyugly" };
	Console.WriteLine(array[0]);



}