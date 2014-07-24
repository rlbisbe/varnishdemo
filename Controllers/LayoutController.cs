using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace varnishdemo.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult Sidebar()
        {
			ViewData ["now"] = String.Format ("{0:HH:mm:ss}", DateTime.Now);
			System.Threading.Thread.Sleep (3000);
            return View ("Sidebar");
        }

		public ActionResult Header()
		{
			ViewData ["now"] = String.Format ("{0:HH:mm:ss}", DateTime.Now);
			System.Threading.Thread.Sleep (3000);
			return View ("Header");
		}
    }
}
