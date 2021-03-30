using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeTask9.UserModels
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(150)]

        public string LastName { get; set; }
        public int Age { get; set; }


        public int? StoryId { get; set; }
        public Story Stories { get; set; }
        public int? AuthorId { get; set; }
        public Author Authors { get; set; }
    }
}