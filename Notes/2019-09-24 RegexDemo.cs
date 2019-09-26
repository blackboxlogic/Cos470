using System;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace demo
{
	public class RegexDemo
	{
		public void DoStuff()
		{
			//(207)-999-9999
			// +1-207-999-9999


			//* ^ . * + ? / [ABC][A - C](a | b) $

			string[] testString = new[]
			{
				@"+1-207-999-9999",
				@"+1m207m999m9999",
				@"(207)-999-9999",
				@"+1-207-999-dogs"
			};

			Regex pattern = new Regex(@"\+1.207.[0-9]{3}.[0-9]{4}", RegexOptions.Compiled);

			foreach (var test in testString)
			{
				if (Regex.IsMatch(test, @"\+1.207.[0-9]{3}.[0-9]{4}"))
				{
					Console.WriteLine(test);
				}
			}

			
			//MatchCollection matchCollection = regex.Matches(testStringGood);
			//foreach (Match match in matchCollection)
			//	Console.WriteLine("Number found at index " + match.Index + ": " + match.Value);

		}

		public class aniaml
		{
			public string name;
		}
	}
}
