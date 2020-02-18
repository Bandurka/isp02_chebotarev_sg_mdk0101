using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Book
    {
        private string title { get; set; }
        private string[] authors { get; set; }
        public int price { get; set; }

        public Book(string bookTitle, string[] bookAuthors, int bookPrice)
        {
            title = bookTitle;
            authors = bookAuthors;
            price = bookPrice;
        }

        public override string ToString()
        {
            string book = title + " " + price;

            foreach (var author in authors)
                book += author + " ";
            return book;
        }
    }
}
