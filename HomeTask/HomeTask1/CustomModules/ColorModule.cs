using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HomeTask1.CustomModules
{
    static class ColorModule
    {

        public static void Colorconsole(object text, System.ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();


        }


    }
}
