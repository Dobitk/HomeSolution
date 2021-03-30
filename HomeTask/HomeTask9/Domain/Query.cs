using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using HomeTask9.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomeTask9.Domain
{
    public class Query
    {


        public static void RunQuery()
        {
            var _db = new UserDBContext();
            var _query = _db.Characters
                .Include(x => x.Stories)
                .Include(x => x.Authors);
 
            foreach (var item in _query)
            {
                Console.WriteLine($"{item.FirstName}      \t{item.LastName}       \t{item.Age}         \t{item.Stories.Name}        \t{item.Authors.Name}");
            }
        }
    }
}
