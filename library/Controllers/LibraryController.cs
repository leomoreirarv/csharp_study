using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace library.Controllers
{
	public class LibraryController : Controller
	{
		public ActionResult Index()
		{
			BookController book = new BookController("Luiz de Camões", "Os Lusiadas", new DateTime(1572), 1);
			ViewData["book"] = book.ViewData;
			return View();
		}
	}
}
