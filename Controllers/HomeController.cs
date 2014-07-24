using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace varnishdemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["now"] = String.Format ("{0:HH:mm:ss}", DateTime.Now);
			System.Threading.Thread.Sleep (3000);
			return View ("Index");
		}
	}
}

