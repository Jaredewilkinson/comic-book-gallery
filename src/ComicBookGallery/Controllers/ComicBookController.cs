using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Super Mario 64";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Super Mario 64 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.<p>";
            ViewBag.artists = new string[]
            {
        "Mario",
        "Princess Peach",
        "Bowser",
        "Toad",
        "Yoshi"
            };
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{

            //    return View();
            //}
            return View();

        }

    }
}