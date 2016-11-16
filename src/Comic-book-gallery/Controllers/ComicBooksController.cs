using Comic_book_gallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Me",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-man survives... <strong>will Me?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name="Dan Slott",Role="Script"},
                    new Artist() { Name="Pesho Ivanov",Role="Pensils"},
                    new Artist() { Name="Ivan Peshov",Role="Inks"},
                    new Artist() { Name="Koko Rabone",Role="Colors"},
                    new Artist() { Name="Koko shisharkata",Role="Letters"}
                }
            };

            return View(comicBook);

        }
    }
}