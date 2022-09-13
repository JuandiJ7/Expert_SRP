using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            BookLocation A7 = new BookLocation("A","7");
            BookLocation B3 = new BookLocation("B","3");
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            A7.AddBook(book1);
            B3.AddBook(book2);
        }
    }
}