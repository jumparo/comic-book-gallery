using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_book_gallery.Controllers
{
    public class ComicBooksController:Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek ==DayOfWeek.Wednesday)
            {
                return new RedirectResult("/");
            }
            return Content("Hello from the Controller");
           //return "Hello from the Controller";

        }
    }
}