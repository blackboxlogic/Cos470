// Github names please!
// Demonstrating understanding is just as valuable as the "right" answer.
using System;

namespace demo
{
	public static class Mathy
	{
		private static double standardDeviation;

		public static double CalculateStandardDeviation(int[] values)
		{
			var sum = 0;
			int total = 0;

			for (int i = 0; i <= values.Length; i++)
			{
				sum = sum + values[i];
			}

			var max = sum / values.Length;
			// This is the deviation sum.
			int deviationSum = 0;

			foreach (var value in values)
			{
				deviationSum = deviationSum + (int) Math.Abs(value - max);
			}

			standardDeviation = deviationSum / values.Length;
			Console.WriteLine("The standard deviation is: " + standardDeviation);

			return standardDeviation;
		}
	}
}
