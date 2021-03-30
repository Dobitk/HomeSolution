using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.DelegateModule
{
    delegate T DelegateUser<T>(T InName);
 
    class RunDelegate
    {
        public static void RunDelegate1<T>(T ver)
        {
            DelegateUser<T> delegateUser = ver => ver;

            Console.WriteLine($"Тип переменной - {typeof(T)} Значение - {delegateUser(ver)}");


        }
        

    }
}
