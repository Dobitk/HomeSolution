using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask8.UserModels;

namespace HomeTask8.Repositories
{
    class BookAuthorRepository
    {
        public static List<BookAuthor> BookAuthors()
        {
            var bookAuthors = new List<BookAuthor>
            {
                new BookAuthor() { Author = "Alan Alexander Milne", NameBook = "Wonnie-the-Pooh", Genre = "Fairy tale" },
                new BookAuthor() { Author = "Arthur Conan Doyle", NameBook = "Sherlock Holmes ", Genre = "Adventure" },
                new BookAuthor() { Author = "Bram Stoker's", NameBook = "Dracula", Genre = "Horror" },
                new BookAuthor() { Author = "Daniel Defoe", NameBook = "Robinson Crusoe", Genre = "Novel" }
                
            };
            return bookAuthors;
        }

    }
}
