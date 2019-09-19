using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
	public class MultithreadDemo
	{
		//ConcurrentQueue<int> x;
		//private object LockableReference = new object();
		public int SharedResource = 0;

		public void DoStuff()
		{
			Console.WriteLine("I did the stuff.");
			
		}
	}
}
