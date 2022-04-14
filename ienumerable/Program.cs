using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ienumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var count = listInt.Count;


		}

		public interface IEnumerable
		{
			IEnumerable GetEnumerable();
		}

		public interface IEnumerable<out T> : IEnumerable
		{
			IEnumerable<T> GetEnumerator();
		}

		
	}
}
