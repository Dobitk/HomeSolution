using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.EventsModule
{
    class Mouse
    {

        public static void Mouses()
        {
            Console.WriteLine("Создаем класс издателя Cat события");
            Console.WriteLine("Cat cat = new Cat();");
            Cat cat = new Cat();
            Console.WriteLine("Подписываюсь на событие в классе Mouse, без делегата");
            Console.WriteLine("cat.WakeUpEvent += RunMouseHandler;");
            cat.WakeUpEvent += RunMouseHandler;
            Console.WriteLine("Запускаю метод издателя для вызова события в Сat");
            Console.WriteLine("cat.onWakeUpEvent();");
            cat.onWakeUpEvent();

        }

        public static void RunMouseHandler()
        {
            Console.WriteLine("Событие кота вызвало метод мыши.");
        }
    }
}
