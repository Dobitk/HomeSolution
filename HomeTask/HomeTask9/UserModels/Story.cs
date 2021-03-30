using System.Collections.Generic;

namespace HomeTask9.UserModels
{
    public class Story
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }


        public List<Character> Characters { get; set; } = new List<Character>();

    }
}