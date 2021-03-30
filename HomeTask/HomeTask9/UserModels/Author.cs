using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using HomeTask9.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HomeTask9.UserModels
{
    public class Author
    {
        public int Id { get; set; }

        [StringLength(50)]
        
        public string Name { get; set; }

        public int NameState { get; set; }



        public List<Character> Characters { get; set; } = new List<Character>();



    }
}
