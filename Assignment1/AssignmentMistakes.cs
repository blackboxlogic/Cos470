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
			if (number >= 97 && number <= 122)
			{
				return number - 96;
			}

			return 0;
		}

		public void PleaseUseForEachLoops(string[] words)
		{
			for (int i = 0; i < words.Length; i++)
			{
				for (int j = 0; j < words[i].Length; j++)
				{
					MagicNumbers(words[i][j]);
				}
			}
		}

		public void ReallyPleaseUseForEach(string[] words)
		{
			int i = 0;
			List<string> dollars = new List<string>();

			while (i < words.Length)
			{
				if (CheckBeforeDoneCounting(words[i]) == 100)
				{
					dollars.Add(words[i]);
				}
				i++;
			}
		}

		public string RepeatedStringConcat(string[] words)
		{
			string DollarWords = "";

			foreach (var word in words)
			{
				DollarWords = DollarWords + word + "\r\n";
			}

			return DollarWords;
		}

		public void EverythingInMain(string[] args)
		{
			// AAAHHHHHH
		}

public
			void			CodeFormat()
			        {

	}


		public int CheckBeforeDoneCounting(string line)
		{
			var sum = 0;

			foreach (char c in line)
			{
				sum += MagicNumbers(c);

				if (sum == 100)
				{
					return sum; // I found a DollarWord! :D
				}
			}

			return sum;
		}

		public void ForgotToDisposeStream(string filePath)
		{
			System.IO.StreamReader file = new System.IO.StreamReader(filePath);
			string x = file.ReadLine();
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
	}
}
