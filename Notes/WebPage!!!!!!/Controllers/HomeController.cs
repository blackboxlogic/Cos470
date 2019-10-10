using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPage______.Models;
using WebPage______.DataLayer;

namespace WebPage______.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var apiResult = Vet.GetTheCats();

			return View(apiResult);
		}

		[HttpPost]
		public ActionResult<int> NewCat([FromBody] string catName)
		{
			var id = Vet.AddNewCat(catName);
			return new ActionResult<int>(id);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
