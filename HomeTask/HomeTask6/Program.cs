using System;
using HomeTask6.UserModules;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {

            OneConditionModule.OneRunCondition();
            Console.WriteLine(Environment.NewLine);
            TwoConditionModule.TwoRunCondition();
        }
    }
}
