using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHomework.Models
{
    public class Book
    {
        public Book(string author, string title, string pages, BookType type) // cia enum konstruktoriuje ?
        {
            this.BookAuthor = author;
            this.BookTitle = title;
            this.BookPages = pages;
            BookID = Guid.NewGuid();
        }


        public string BookAuthor { get; set; }
        public string BookTitle { get; set; }
        public string BookPages { get; set; }
        public Guid BookID { get; set; }

        public BookType MyBookType { get; set; } // pakurtas enum su zanrais knygu, su situ uztesinu?


    }
}
