using LINQ.HelpMaterial;
using System;
using System.Linq;

namespace HomeTask6.UserModules
{
    class OneConditionModule
    {
        public static void OneRunCondition()
        {
            var characters = CharactersRepository.GetCharacters();
           // string PersonDescription;
            var _queryLINQ = from character in characters
                select new
                {
                    PersonDescription =
                        character.FirstName + "  " + character.LastName + "  " + character.Gender + "  " +
                        character.Age + "  " + character.StoryId + "  " + character.StoryName
                };


           foreach (var item in _queryLINQ)
            {
                Console.WriteLine(item.PersonDescription );

            }



        }


    }
}
