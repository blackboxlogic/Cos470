using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
	public static class FluentInts
	{
		public static int DoStuff()
		{
			int x = 100;
			x = Increment(x);
			x = Double(x);
			x = Increment(x);
			x = Tripple(x);
			x = Half(x);
			x = AddRandom(x, 10);
			x = Quadruple(x);
			x = AddRandom(x, 10);
			x = Half(x);
			x = Decrement(x);

			x.Increment().Double().Increment().Tripple().Half().AddRandom(10);

			return x;
		}

		public static int Double(this int x)
		{
			return x * 2;
		}

		public static int Tripple(this int x)
		{
			return x * 3;
		}

		public static int Quadruple(this int x)
		{
			return x * 4;
		}

		public static int AddRandom(this int x, int max)
		{
			Random r = new Random();
			return x + r.Next(max);
		}

		public static int Increment(this int x)
		{
			return x + 1;
		}

		public static int Decrement(this int x)
		{
			return x + 1;
		}

		public static int Half(this int x)
		{
			return x / 2;
		}
	}
}
