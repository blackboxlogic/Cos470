using System;
using System.Linq;

namespace demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FluentInts.DoStuff();
			LinqDemo.DoStuff();
			ConfigDemo.DoStuff();
			JsonDemo.DoStuff();
			WebRequestDemo.DoStuff();

			Console.WriteLine("Hello World!");
		}

		// Must be public to be seen from the unit test project.
		public static int CountAs(string input)
		{
			return input.Count(a => a == 'a' || a == 'A');
		}
	}
}
