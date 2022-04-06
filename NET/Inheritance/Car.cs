using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Car : Vehicle
	{
		public string name { get; set; }

		public Car (string cName) {
			this.name = cName;
		}

	}
}
