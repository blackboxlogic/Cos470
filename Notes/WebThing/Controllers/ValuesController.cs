using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebThing.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		static Dictionary<int, string> DataLayer = new Dictionary<int, string>();

		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return DataLayer.Select(kvp => kvp.Key + "-" + kvp.Value).ToArray();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			if (DataLayer.ContainsKey(id))
			{
				return DataLayer[id];
			}
			else
			{
				return new NotFoundResult();
			}
		}

		[HttpPut("countHistory")]
		public ActionResult<DataModel> PutCount([FromBody]DataModel history)
		{
			return history;
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
			int max = DataLayer.Keys.DefaultIfEmpty().Max() + 1;
			DataLayer[max] = value;
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			DataLayer[id] = value;
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			DataLayer.Remove(id); // safe
		}
	}

	public class DataModel
	{
		public Location[] locations;
	}

	public class Location
	{
		public static readonly DateTime UnixEpoc = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

		public DateTime Time => UnixEpoc.AddMilliseconds(timestampMs);
		public long timestampMs;
		public int latitudeE7;
		public int longitudeE7;
		public int accuracy;
		public Activity[] activity;
	}

	public class Activity
	{
		public long timestampMs;
		public Guess[] activity;
	}

	public class Guess
	{
		public string type;
		public int confidence;
	}
}
