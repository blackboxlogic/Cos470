using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebPage______.Models;
using DataAccessLayer.Model;

namespace WebPage______.Controllers
{
	public class HomeController : Controller
	{
		private readonly NorthwindContext Context;
		public HomeController()
		{
			Context = new NorthwindContext();
		}

		public IActionResult Index()
		{
			//var apiResult = Vet.GetTheCats();
			var employees = Context.Employees.ToDictionary(e => e.EmployeeId, e => e.LastName);

			return View(new Cats() { IdToName = employees });
		}

		public class ZZZ
		{
			public string name;
			public int age;
		}

		[HttpPost]
		public ActionResult<int> DoThing([FromBody] ZZZ thing)
		{
			return thing.name.Length;
		}

		[HttpPost]
		public ActionResult<int> NewCat([FromBody] string catName)
		{
			// An API
			//var id = Vet.AddNewCat(catName);
			// Raw SQL
			//DataLayer.DatabaseVet.Add(catName);
			// Entity Framework

			string first = catName.Substring(0, 10);
			string last = catName.Substring(0, 20);
			var employee = Context.Employees.Add(new Employees() { FirstName = first, LastName = last });
			Context.SaveChanges();
			return new ActionResult<int>(employee.Entity.EmployeeId);
		}

		[HttpDelete]
		public ActionResult deletify([FromBody] int id)
		{
			//Vet.Deletify(id);
			//DataLayer.DatabaseVet.Delete(id);
			var employee = Context.Employees.First(e => e.EmployeeId == id);
			Context.Remove(employee);
			Context.SaveChanges();
			return new OkResult();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
