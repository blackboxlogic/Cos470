using Microsoft.Extensions.Configuration;
using System;

namespace demo
{
	class ConfigDemo
	{
		public static void DoStuff()
		{
			// Requires nuget package reference: Microsoft.Extension.Configuration.Json
			// Requiers the file `appsettings.json` in your project (Make sure property 'Copy to output directory' is not 'do not copy')
			var config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", false, true)
				.Build();

			var planet = config["Planet"];
			var greeting = config["greeting"];
			Console.WriteLine($"{greeting} {planet}");
		}
	}
}
