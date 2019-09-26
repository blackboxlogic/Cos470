using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
	public class Program
	{
		//private readonly static object lockObject = new object();

		private static ConcurrentDictionary<int, int> ThreadSafeData = new ConcurrentDictionary<int, int>();

		public static void Main(string[] args)
		{

			Dictionary<int, int> basicDictionary = new Dictionary<int, int>();
			//ThreadSafeData.AddOrUpdate


			Console.WriteLine("starting");
			Task.Run(Tick);
			Task.Run(Tock);
			Console.WriteLine("started");

			Console.ReadKey();
		}

		public static void Tick()
		{
			while (true)
			{
					Console.WriteLine("tick");
					for (int i = 0; i < 20; i++)
						Console.Write(i);
					Console.WriteLine();
				Thread.Sleep(110);
			}
		}

		public static void Tock()
		{
			while (true)
			{
					Console.WriteLine("tock");
					for (int i = 20; i > 0; i--)
						Console.Write(i);

					Console.WriteLine();
				Thread.Sleep(130);
			}
		}

		// Must be public to be seen from the unit test project.
		public static int CountAs(string input)
		{
			return input.Count(a => a == 'a' || a == 'A');
		}
	}
}
