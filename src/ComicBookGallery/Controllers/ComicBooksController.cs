using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Super Mario 64 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.<p>";
            ViewBag.Artists = new string[]
            {
                "Mario",
                "Princess Peach",
                "Bowser",
                "Toad",
                "Yoshi"
            };
         
            return View();

        }

    }
}