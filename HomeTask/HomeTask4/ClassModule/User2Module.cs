using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.DelegateModule
{
    class User2Module
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static void OutDelegate2(int x, int y)
        {
            
            int m = x + y;
            Console.WriteLine("Delegate2(). Число при сложении равно - "+m);
            Console.WriteLine(Environment.NewLine);
        }


    }
}
