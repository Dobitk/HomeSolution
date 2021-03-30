using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeTask8.UserModels
{
    public class Author
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
 //      public List<Story> Stories { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();



    }
}
