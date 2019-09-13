using Microsoft.Extensions.Configuration;
using System;

namespace demo
{
	class ConfigDemo
	{
		/*
		Add a file `appsettings.json` to your project (Make sure property 'Copy to output directory' is not 'do not copy')
		{
		  "planet": "world",
		  "greeting": "hello"
		}
		*/
		public void doSomething()
		{
			// Requiers nuget package reference: Microsoft.Extension.Configuration.Json
			var config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", false, true)
				.Build();

			var planet = config["Planet"];
			var greeting = config["greeting"];
			Console.WriteLine($"{greeting} {planet}");
		}
	}
}
