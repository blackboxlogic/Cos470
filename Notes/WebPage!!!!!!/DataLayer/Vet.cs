using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebPage______.Models;
using System.Net.Http.Headers;

namespace WebPage______.DataLayer
{
	// Data layer
	public static class Vet
	{
		public static int AddNewCat(string catName)
		{
			var address = @"https://webthing20191008043036.azurewebsites.net/api/Values/";

			// Disposing HttpClient is not best practice. It's good enough and I'm keeping this simple.
			using (var client = new HttpClient())
			{
				using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, address))
				{
					request.Content = new StringContent("\"" + catName + "\"");
					request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
					// .Result from an Async function is not best practice. It's good enough and I'm keeping this simple.
					var response = client.SendAsync(request).Result;
					var content = response.Content.ReadAsStringAsync().Result;
					if (!response.IsSuccessStatusCode)
					{
						throw new Exception($"{ content}: {response.StatusCode}");
					}

					var newKey = JsonConvert.DeserializeObject<int>(content);

					return newKey; // the content of the response
				}
			}
		}

		public static Cats GetTheCats()
		{
			// Using HttpUtility to generate the parameters for the query string handles HTTP escaping the values.
			// Change these:
			//var parameters = HttpUtility.ParseQueryString(string.Empty);
			//parameters["where"] = "MUNICIPALITY='Limestone'";
			//parameters["outFields"] = "ADDRESS_NUMBER,STREETNAME,SUFFIX,MUNICIPALITY,Latitude,longitude";
			//parameters["f"] = "pjson";
			//parameters["resultRecordCount"] = "10";

			////
			var address = @"https://webthing20191008043036.azurewebsites.net/api/Values/";

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
						throw new Exception($"{ content}: {response.StatusCode}");
					}

					var model = JsonConvert.DeserializeObject<Dictionary<int, string>>(content);

					return new Cats() { IdToName = model }; // the content of the response
				}
			}
		}
	}
}
