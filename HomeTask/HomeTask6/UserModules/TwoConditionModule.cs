using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace HomeTask6.UserModules
{
    class TwoConditionModule
    {
        public static void TwoRunCondition()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();



            var ggg = from character in characters
                join story in stories on character.StoryId equals story.Id
                select new CharasterStory(character.FirstName, character.LastName, character.Gender, character.Age, 
                    character.StoryName, story.Name, story.Description);
 
                   
      

       

            //Без анонимных объекта не получается



            foreach (var item in ggg)
            {
                Console.WriteLine("{0}        \t{1}        \t{2}        \t{3}",
                                   item.FirstName,item.StoryName,item.Name,item.Description );
            }

            
        }

    }
}
