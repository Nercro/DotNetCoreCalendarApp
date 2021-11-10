using CalendarApop.Data;
using CalendarApop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApop.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IDataAccessLayer _idal;

		public HomeController(ILogger<HomeController> logger, IDataAccessLayer idal)
		{
			_logger = logger;
			_idal = idal;
		}

		public IActionResult Index()
		{
			var myEvent = _idal.GetCalendarEvent(1);
			return View();
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
