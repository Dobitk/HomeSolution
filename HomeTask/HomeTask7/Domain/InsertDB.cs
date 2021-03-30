using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask7.Repositories;

namespace HomeTask7.Domain
{
    class InsertDB
    {
        public static void DBInsert()
        {
            var BookAuthor = BookAuthorRepository.BookAuthors();
            var _dbContaxt = new UserDBContext();

            foreach (var item in BookAuthor)
            {
                _dbContaxt.BookAuthors.Add(item);
            }

            _dbContaxt.SaveChanges();
            Console.WriteLine("Данные добавлены в базу");

        }
    }
}
