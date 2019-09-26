using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
	public class Assignment2Mistakes
	{
		public void DoStuff()
		{
			// Don't hardcode paths
			String url_config = "C:\\Users\\windows\\Desktop\\school\\cos470\\ass0\\Cos470\\cos470\\Assignment2\\cOS470\\DollarAddresses\\appsettings.json";

			// Oh yeah, json can deserialize a List like it was an array
			// public List<Attribute> features { get; set; }

			// Maybe use initializers
			var addresses = new List<Address>();
			var address = new Address();
			address.ADDRESS_NUMBER = 2;
			address.STREETNAME = "a";
			address.SUFFIX = "a";
			addresses.Add(address);
			//or:
			//var addresses = new List<Address>()
			//{
			//	new Address()
			//	{
			//		ADDRESS_NUMBER = 2,
			//		STREETNAME = "a",
			//		SUFFIX = "a"
			//	}
			//};
		}

		public class Address
		{
			public int ADDRESS_NUMBER;
			public string STREETNAME;
			public string SUFFIX;
		}
	}
}
