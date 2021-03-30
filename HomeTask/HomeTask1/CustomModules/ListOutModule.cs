using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1.CustomModules
{
    static class ListOutModule
    {
        public static void ArrayListOutForeach(ArrayList list)
        {
            foreach (var Listitem in list)
            {
                ColorModule.Colorconsole(Listitem, ConsoleColor.Gray);
            }
        }

        public static void ArrayListOutFor(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                ColorModule.Colorconsole(list[i], ConsoleColor.Gray);
            }
        }

        public static void AllOutForeach(IEnumerable list)
        {
            foreach (var item in list)
            {
                ColorModule.Colorconsole(item, ConsoleColor.Gray);
            }
        }

        public static void HashOutForeach(IDictionary list)
        {
            foreach (DictionaryEntry item in list)
            {
                ColorModule.Colorconsole("  " + item.Key + " : " + item.Value, ConsoleColor.Gray);
            }

        }

 
    }
}
