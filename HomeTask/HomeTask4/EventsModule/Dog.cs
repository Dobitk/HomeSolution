using System;
using System.Collections.Generic;
using System.Text;
using HomeTask4.EventsModule;

namespace HomeTask4.EventsModule
{
    
    class Dog
    {
        

        public static void Dogs()
        {
            Console.WriteLine("Создаем класс издателя Cat события");
            Console.WriteLine("Cat cat = new Cat();");
            Cat cat = new Cat();
            Console.WriteLine("Создаю делегат объявленный в классе Cat");
            Console.WriteLine("D1 deleg = new D1(RunDogHandler);");
            D1 deleg = new D1(RunDogHandler);
            Console.WriteLine("Подписываюсь на событие в классе Dog");
            Console.WriteLine("cat.WakeUpEvent += deleg;");
            cat.WakeUpEvent += deleg;
            Console.WriteLine("Запускаю метод издателя для вызова события в Сat");
            Console.WriteLine("cat.onWakeUpEvent();");
            cat.onWakeUpEvent();
            
        }

        public static void RunDogHandler()
        {
            
            Console.WriteLine("Событие кота вызвало метод собаки.");
        }



    }
}
