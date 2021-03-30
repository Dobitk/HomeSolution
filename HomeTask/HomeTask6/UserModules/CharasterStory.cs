using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6.UserModules
{
    class CharasterStory
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string StoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public CharasterStory(string firstName, string lastName, bool gender, int age, string storyName, string name,
            string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            StoryName = storyName;
            Name = name;
            Description = description;
        }
    }

    
}
