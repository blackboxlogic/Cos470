using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
	class AssignmentMistakes
	{
		public int MagicNumbers(char number)
		{
			if (number >= 'a' && number <= 'z')
			{
				return number - 'a' + 1;
			}

			return 0;
		}

		public void PleaseUseForEachLoops(string[] words)
		{
			foreach (var word in words)
			{
				foreach (var c in word)
				{
					MagicNumbers(c);
				}
			}
		}

		public void ReallyPleaseUseForEach(string[] words)
		{
			List<string> dollars = new List<string>();

			foreach (var word in words)
			{
				if (CheckBeforeDoneCounting(word) == 100)
				{
					dollars.Add(word);
				}
			}
		}

		public string RepeatedStringConcat(string[] words)
		{
			StringBuilder x;
			List<string> results = new List<string>();
			string DollarWords = "";

			foreach (var word in words)
			{
				results.Add(word);
				DollarWords = DollarWords + word + "\r\n";
			}


			string.Join("\r\n", results);
			return DollarWords;
		}

		public void EverythingInMain(string[] args)
		{
			// AAAHHHHHH
		}

		public void CodeFormat()
		{

		}

		public int CheckBeforeDoneCounting(string line)
		{
			var sum = 0;

			foreach (char c in line)
			{
				sum += MagicNumbers(c);
			}

			if (sum == 100)
			{
				return sum; // I found a DollarWord! :D
			}

			return sum;
		}

		public void ForgotToDisposeStream(string filePath)
		{
			using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
			{
				string x = file.ReadLine();
			}
		}

		public void UXinBusinessLogic(string filePath)
		{

		}

		public void GoingTheLongWayAround(char c)
		{
			int WordCountAmount = 0;

			if (c == 'A' || c == 'a')
			{
				WordCountAmount += 1;
			}
			if (c == 'B' || c == 'b')
			{
				WordCountAmount += 2;
			}
			//...
			if (c == 'Z' || c == 'z')
			{
				WordCountAmount += 26;
			}
		}

		// DoingWorkOutsideOfAFunction
		static string text = System.IO.File.ReadAllText(@"C:\Users\luker\source\repos\Cos470\Assignment1\words.txt");
		static string[] words = text.Split("\n");

		static void YES(string[] args)
		{
			//var words = ReadWords(InputFilePath);
			//var dollarWords = GetDollarWords(words);
			//OutputToFile(OutputFilePath, dollarWords);
			//OutputAggregateDataToConsole(words, dollarWords);
			//Console.Read();
		}

		public void Almost(string[] words)
		{
			words.OrderByDescending(w => w.Length).First();
		}
	}
}
