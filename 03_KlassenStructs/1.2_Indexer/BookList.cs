using System;

namespace _1._2_Indexer
{
    class BookList
    {
        private string[,] books =
        {
            {"The Green Mile", "Stephen King"},
            {"It", "Stephen King"},
            {"Misery", "Stephen King"},
            {"The Raven", "Edgar Allan Poe"}
        };

        // TODO: Indexer
        public string this[int index]
        {
            get 
            {
                string title = books[index, 0];
                string author = books[index, 1];
                return "title: " + title + " / author: " + author; 
            }
        }

        public string this[string index]
        {
            get
            {
                string output = "Unknown";
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i, 0] == index)
                    {
                        output = books[i, 1];
                        break;
                    }
                }
                return output;
            }
        }

    }
}
