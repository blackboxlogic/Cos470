using System;

namespace demo
{
	class Program
	{
		static void Main(string[] args)
		{
			FluentInts.DoStuff();
			LinqDemo.DoStuff();
			ConfigDemo.DoStuff();
			JsonDemo.DoStuff();
			WebRequestDemo.DoStuff();

			Console.WriteLine("Hello World!");
		}
	}
}
