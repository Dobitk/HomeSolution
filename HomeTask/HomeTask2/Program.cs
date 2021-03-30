using System;
using System.Collections.Generic;
using HomeTask2.GeneralizedClasses;
using HomeTask2.UserClasses;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumeratorUserClass fdList = new EnumeratorUserClass();
//            fdList.AddUser("Boston");
            fdList.AddUser(25);
//            fdList.AddUser(13.6);
            fdList.AddUser(100);
            fdList.AddUser(55);
            fdList.AddUser(15);
            fdList.AddUser(5);
            fdList.AddUser(1);

            foreach (var item in fdList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Удаляем элемет < 100 >");
            fdList.RemoveUser(100);

            Console.WriteLine(Environment.NewLine);

            foreach (var item in fdList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Удаляем элемет < 5 >");
            fdList.RemoveUser(5);
            foreach (var item in fdList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Создаем обобщенный класс GeneralizedClass<T, R> и выводим R < Boston >");

            var MyT = new UserType();
            MyT._Name = "Boston";

            GeneralizedClass<int, UserType> GenericUser = new GeneralizedClass<int, UserType>(25, MyT);
            Console.WriteLine(GenericUser.Generic());
            Console.Read();
        }
    }
}
