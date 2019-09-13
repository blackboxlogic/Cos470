using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace demo
{
	public static class LinqDemo
	{
		// For practice, implement these functions:
		//static string AverageNameLength(string[] names)
		//static string LongestName(string[] names)
		//static string[] NamesAlphabeticalByTheirReverse(string[] names)
		//static string[] NamesThatArePalindromes(string[] names)
		//static char MostCommonLetter(string[] names)
		//static int AverageNumberOfVowels(string[] names)
		//static Dictionary<char, int> CharacterFrequency(string[] names)
		//static char LetterThanOccursMostInASingleName(string[] names)
		public static string[] Names = new[] { "Alex", "Josh", "Daniel", "Miguel", "Nick", "Jesse", "Shea", "Lincoln", "Jon", "Manda", "Dennis", "Zachary", "Bobby", "Luke", "Fazil", "Jennifer", "Dejan" };

		public static void DoStuff(IEnumerable<int> data)
		{
			// notData is not data! it is a process for getting data
			IEnumerable<cat> notData = data.Distinct()
				.TakeLast(5)
				.OrderBy(x => x)
				.Where(x => x % 3 == 0)
				.Select(a => new cat(a));

			cat[] cats = notData.ToArray(); // enumerating the collection *creates cats* and stores them.
			var count = cats.Count(); // I can count the count the cats.
			var reCount = notData.Count(); // If I enumerate the collection again, I make new cats.
		}
	}

	public class cat
	{
		private string Name;

		public cat(int name)
		{
			Name = name.ToString();
			Console.Beep();
		}
	}
}
