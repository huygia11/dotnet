using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*int a = 5;
			int b = 4;
			try
			{
				var c = a / b;
				Console.WriteLine(c);
				int[] i = { 1, 2 };
				var x = i[5];
			}
			catch (DivideByZeroException loi)
			{
				Console.WriteLine(loi.Message);
				Console.WriteLine("khong duoc chia cho 0");
			}
			catch (IndexOutOfRangeException e2)
			{
				Console.WriteLine(e2.Message);
				Console.WriteLine("chi so mang khong phu hop");
			}
			catch (Exception e1)
			{
				Console.WriteLine(e1.Message);
			}
			Console.WriteLine("ket thuc");*/







			string path = "1.txt";
			try
			{ 
				string s = File.ReadAllText(path);
				Console.WriteLine(s);
			}
			catch (FileNotFoundException fnfe)
			{
				Console.WriteLine(fnfe.Message);
				Console.WriteLine("file ko ton tai");
			}
			catch (ArgumentNullException ane)
			{
				Console.WriteLine(ane.Message);
				Console.WriteLine("file ko dc null");
			}
			



		}
	}
}
