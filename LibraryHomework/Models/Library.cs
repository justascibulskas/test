using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHomework.Models
{
    class Library
    {
        public Library(string addres, string workingTime)
        {
            this.LibraryAddres = addres;
            this.LibraryWorkingTime = workingTime;
            Books = new List<Book>(); // sukuriu bibliotekoje lista konstruktoriuje?
        }


        public List<Book> Books { get; set; } 
        public string LibraryAddres { get; set; }
        public string LibraryWorkingTime { get; set; }



        //dedu knygas i lista bibliotekos ?
        public Book AddBook (Book bookName)
        {
            this.Books.Add(bookName);
            return null;
        }

    }
}
