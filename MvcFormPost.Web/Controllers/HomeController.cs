using System.Web.Mvc;

namespace MvcFormPost.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Update()
		{
			var textValue = Request.Form["TextValue"];
			var checkValue = Request.Form["CheckValue"];

			ViewBag.TextValue = textValue;
			ViewBag.CheckValue = checkValue;

			return View();
		}
	}
}
