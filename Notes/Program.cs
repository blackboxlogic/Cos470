using Newtonsoft.Json;
using System;
using System.Linq;

namespace demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			dynamic tom = new Carrot();

			tom.Grow();
			tom.Fry();


			Console.ReadKey();
		}

		// Must be public to be seen from the unit test project.
		public static int CountAs(string input)
		{
			return input.Count(a => a == 'a' || a == 'A');
		}
	}

	public abstract class Plant // can have implementation
	{
		public virtual void Grow() // virtual means CAN be overriden
		{
			Console.WriteLine("wiggle wiggle wiggle");
		}

		public abstract void Ripen(); // abstract means MUST be overriden
	}

	public interface IEdible // Promise some behavior
	{
		void BeEaten(); // Anything in an interface, must be implemented
	}

	public interface IPlantable // Promise some behavior
	{
		void BePlanted();
	}

	public sealed class Carrot : Plant, IEdible, IPlantable
	{
		public void BeEaten()
		{
			Console.WriteLine("crunch");
		}

		public void BePlanted()
		{
			Console.WriteLine("plop");
		}

		public override string ToString()
		{
			return "Hello! I am a: " + base.ToString();
		}

		public override void Grow()
		{
			Console.WriteLine("waggle waggle waggle");
		}

		public override void Ripen()
		{
			
		}
	}
}
