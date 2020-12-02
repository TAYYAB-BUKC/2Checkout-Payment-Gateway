using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentGateway._2CheckOut.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Click the button below to order!";

			return View();
		}


		//public ActionResult Checkout()
		//{
		//	var dictionary = new Dictionary<string, string>();
		//	dictionary.Add("sid", "1817037");
		//	dictionary.Add("cart_order_id", "Test Cart");
		//	dictionary.Add("total", "1.00");
		//	String PaymentLink = TwocheckoutCharge.Link(dictionary);
		//	Response.Redirect(PaymentLink);
		//	return View();
		//}


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
	}
}