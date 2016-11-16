﻿using System;
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

            ViewBag.SeriesTitle = "The Amazing Me";
            ViewBag.IssueNumber= 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-man survives... <strong>will Me?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();

        }
    }
}