using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace library.Controllers
{
	public class BookController : Controller
	{
		private string Author;
		private string Title;
		private DateTime Year;
		private int Edition;

		public BookController(string Author, string Title, DateTime Year, int Edition)
		{
			this.Author = Author;
			this.Title = Title;
			this.Year = Year;
			this.Edition = Edition;
		}

		List<string> ShowData()
		{
			List<string> ListData = new List<string>();
			ListData.Add(Author);
			ListData.Add(Title);

			return ListData;
		}

	}
}
