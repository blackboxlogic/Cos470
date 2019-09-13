using NUnit.Framework;

namespace Tests
{
	// Right click solution -> add -> new project -> NUnit test project (.net core)
	// Add a project reference to project you want to test
	// Run tests: test -> windows -> test explorer -> double green arrow
	public class Tests
	{
		// This test doesn't need any setup, but you might.
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void Test1()
		{
			// This test will run once
			Assert.IsTrue(1 == 1);
		}

		[TestCase("a", ExpectedResult = 1)]
		[TestCase("", ExpectedResult = 0)]
		[TestCase("b", ExpectedResult = 0)]
		[TestCase("   a", ExpectedResult = 1)]
		[TestCase("a    ", ExpectedResult = 1)]
		[TestCase("a    a", ExpectedResult = 2)]
		[TestCase("AaAa", ExpectedResult = 4)]
		[TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", ExpectedResult = 50)]
		[TestCase("1234568790qwertyiuopsdfghjlkzxcvbnm", ExpectedResult = 0)]
		public int Test2(string input)
		{
			// This test will run many times, each time with different input
			return demo.Program.CountAs(input);
		}

	}
}