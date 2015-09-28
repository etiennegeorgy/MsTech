using System;

namespace _1._1_Konstruktor
{
    class Book
    {
        private string title;
        private string author;
        private bool available;

        public Book(string title, string author, bool available)
        {
            {
                // TODO: Felder initialisieren
                this.title = title;
                this.author = author;
                this.available = available;
            }
        }

        // TODO: Konstruktor mit title / author
        public Book(string title, string author) : this(title, author, true)
        {
            
        }
        // TODO: Konstruktor mit title
        public Book(string title) : this(title, "anonymous", false)
        {

        }
        // TODO: Default-Konstruktor
        public Book() : this("untitled", "anonymous", false)
        {

        }
        // TODO: ToString()-Methode
        public override string ToString()
        {
            return title + ", " + author + ", " + available;
        }
    }

}
