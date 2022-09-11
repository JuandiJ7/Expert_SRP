using System;

namespace SRP
{
    public class Book /*La clase no cumple con el 
    principio SRP ya que no solo tiene una responsabilidad sobre el libro 
    (conocer su título, su autor y su código), sino que también tiene una 
    responsabilidad sobre la ubicación del libro. Si se cambia la ubicación
    del libro, se debe cambiar la clase.*/
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }

    public class BookLocation //De esta forma, cada clase tiene su única razón por la cual cambiar.
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public void ShelveBook(String sector, String shelve)
            {
                this.LibrarySector = sector;
                this.LibraryShelve = shelve;
            }
    }
        
}
