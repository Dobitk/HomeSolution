using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7.UserModels
{
    class BookAuthor
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        public string NameBook { get; set; }
        public string Genre { get; set; }

        

    }
}
