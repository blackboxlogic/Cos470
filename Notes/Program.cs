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

			//using (var ctx = new DataAccessLayer.DatabaseContext())
			//{
			//	var stud = new Mouse() { StudentName = "Bill" };

			//	ctx.Students.Add(stud);
			//	ctx.SaveChanges();
			//}
		}
	}
}
