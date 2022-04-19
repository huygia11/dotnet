using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAsp5.Models
{
	public class DependencyInjection
	{
		public class Girl
		{
			public class Bikini
			{
			}

			private Bikini outfit;
			public Girl()
			{
				outfit = new Bikini();
			}

			public interface Outfit
			{
				void wear();
			}


			// https://www.satdevelop.com/blog/huong-dan-va-vi-du-ve-Dependency-Injection

		}
	}
}