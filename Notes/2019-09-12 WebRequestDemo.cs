using System;
using System.Net.Http;
using System.Web;

namespace demo
{
	class WebRequestDemo
	{
		public string DoSomething()
		{
			// Using HttpUtility to generate the parameters for the query string handles HTTP escaping the values.
			var query = HttpUtility.ParseQueryString(string.Empty);
			query["id"] = 20949324.ToString();

			var address = @"https://news.ycombinator.com/item?" + query;

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
