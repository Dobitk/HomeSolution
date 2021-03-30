using System.Collections.Generic;

namespace HomeTask8.UserModels
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public int? StoryId { get; set; }
        public Story Stories { get; set; }
        public int? AuthorId { get; set; }
        public Author Authors { get; set; }
    }
}