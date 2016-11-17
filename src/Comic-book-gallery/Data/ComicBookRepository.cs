using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Comic_book_gallery.Models;

namespace Comic_book_gallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
            {
                new ComicBook()
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
            },
                new ComicBook()
    {
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 700,
        DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
            new Artist() { Name = "Victor Olazaba", Role = "Inks" },
            new Artist() { Name = "Edgar Delgado", Role = "Colors" },
            new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
        },
        Favourite = false
    },
    new ComicBook()
    {
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 657,
        DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Marcos Martin", Role = "Pencils" },
            new Artist() { Name = "Marcos Martin", Role = "Inks" },
            new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
            new Artist() { Name = "Joe Caramagna", Role = "Letters" }
        },
        Favourite = false
    },
    new ComicBook()
    {
        SeriesTitle = "Bone",
        IssueNumber = 50,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favourite= false
    }
    };
        public ComicBook GetComicBook(int id)
        {

            ComicBook comicBookReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id==id)
                {
                    comicBookReturn = comicBook;
                    break;
                }
            }
            return comicBookReturn;
        }
    }
}