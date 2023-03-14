using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoteVote.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Causes()
		{
			return View();
		}

		public ActionResult Login()
		{
			return View();
		}

		public ActionResult SignUp()
		{
			return View();
		}
		public ActionResult ForgottenPassword()
		{
			return View();
		}
		public ActionResult Reset()
		{
			return View();
		}

		public ActionResult CreateACause()
		{
			return View();
		}

	}
}