namespace SRP;
using System.Collections.Generic;

public class BookLocation //De esta forma, cada clase tiene su única razón por la cual cambiar.
    {
        public string LibrarySector { get ; }
        public Dictionary<string, Book> books = new Dictionary<string, Book>();

        public string LibraryShelve { get ; }
        public BookLocation(string sector, string shelve)
            {
                this.LibrarySector = sector;
                this.LibraryShelve = shelve;
            }
        
        public void AddBook(Book miBook){
            this.books.Add(miBook.Code,miBook);
        }
        
    }

