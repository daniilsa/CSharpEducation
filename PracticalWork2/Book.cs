using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    class Book
    {
        string nameBook;
        string author;
        int years;

        public Book()
        {
            this.nameBook = "Сказка о царе Салтане";
            this.author = "Пушкин А.С.";
            this.years = 1831;

        }

        public Book(string nameBook) : this()
        {
            this.nameBook = nameBook;
        }

        public Book(string nameBook, string author) : this()
        {
            this.nameBook = nameBook;
            this.author = author;
        }

        public Book(string nameBook, string author, int years) : this()
        {
            this.nameBook = nameBook;
            this.author = author;
            this.years = years;
        }
        /// <summary>
        /// Вывод информации о книге
        /// </summary>
        /// <param name="book"></param>
        public void GetInfo(Book book)
        {
            Console.WriteLine("Имя автора: " + book.author + "; Название книги: " + book.nameBook);
        }
    }
}
