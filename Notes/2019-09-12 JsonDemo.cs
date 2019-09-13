using Newtonsoft.Json

namespace demo
{
	class JsonDemo
	{
		// Requires nuget package reference: Newtonsoft.Json
		public static void doStuff()
		{
			// This string is easier to work with and understand using something to format it for you, like the JSTools plugin for Notepad++.
			string json = @"{""name"":""SuperZOO!"",""animals"":[{""name"":""cat"",""age"":2},{""name"":""dog"",""age"":4}]}";
			var model = JsonConvert.DeserializeObject<zoo>(json);
			json = JsonConvert.SerializeObject(model);
		}

		//Create class(es) to represent the data model
		public class zoo
		{
			public animal[] animals;
			public string name;
		}

		public class animal
		{
			public string name;
			public int age;
		}
	}
}