using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.EventsModule
{
    class Human
    {
        public static void Humans()
        {
            Console.WriteLine("Создаем класс издателя Cat события");
            Console.WriteLine("Cat cat = new Cat();");
            Cat cat = new Cat();
            Console.WriteLine("Подписываюсь на событие в классе Human, без делегата");
            Console.WriteLine("cat.WakeUpEvent += RunHumanHandler;");
            cat.WakeUpEvent += RunHumanHandler;
            Console.WriteLine("Запускаю метод издателя для вызова события в Сat");
            Console.WriteLine("cat.onWakeUpEvent();");
            cat.onWakeUpEvent();

        }

        public static void RunHumanHandler()
        {
            Console.WriteLine("Событие Cat вызвало метод Human.");
        }
    }
}
