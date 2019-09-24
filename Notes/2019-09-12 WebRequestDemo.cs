using System;
using System.Net.Http;
using System.Web;

namespace demo
{
	class WebRequestDemo
	{
		public static string DoStuff()
		{
			// Using HttpUtility to generate the parameters for the query string handles HTTP escaping the values.
			// Change these:
			var parameters = HttpUtility.ParseQueryString(string.Empty);
			parameters["where"] = "MUNICIPALITY='Limestone'";
			parameters["outFields"] = "ADDRESS_NUMBER,STREETNAME,SUFFIX,MUNICIPALITY,Latitude,longitude";
			parameters["f"] = "pjson";
			parameters["resultRecordCount"] = "10";

			//
			var address = @"https://gis.maine.gov/arcgis/rest/services/Location/Maine_E911_Addresses_Roads_PSAP/MapServer/1/query?"
				+ parameters;

			// Disposing HttpClient is not best practice. It's good enough and I'm keeping this simple.
			using (var client = new HttpClient())
			{
				using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address))
				{
					// .Result from an Async function is not best practice. It's good enough and I'm keeping this simple.
					var response = client.SendAsync(request).Result;
					var content = response.Content.ReadAsStringAsync().Result;
					if (!response.IsSuccessStatusCode)
					{
						throw new Exception($"{content}: {response.StatusCode}");
					}
					return content; // the content of the response
				}
			}
		}
	}
}
