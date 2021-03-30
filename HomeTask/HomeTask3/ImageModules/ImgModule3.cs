using System;
using System.Collections.Generic;
using System.Text;
using HomeTask3.CustomModules;

namespace HomeTask3.ImageModules
{
    class ImgModule3
    {
        public static void Runimg3()
        {
            var FileByte1 = Properties.Resources._3_1;
            var FileByte2 = Properties.Resources._3_2;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Клонирование репозитория");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"1) Необходимо перейти на нужную директорию командой ");
            Console.WriteLine(@"   ""cd < Путь к папке>""");
            Console.WriteLine(@"2) Выполняем команду ""git init""");
            Console.WriteLine(@"3) Клонируем репозиторий командой ");
            Console.WriteLine(@"   git clone https://github.com/Dobitk/HomeSolution.git" );
            Console.WriteLine(@"8) Потом, каждый раз при загрузке обновлений из удаленного репозитория, вводим только команду ");
            Console.WriteLine(@"   ""git pull""");


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Нажмите любую клавишу для просмотра .....");


            Console.WriteLine("Нажмите любую клавишу для просмотра.....");

            Console.ReadLine();
            RunImagesModule.RunImages("2_1.png", FileByte1);


            Console.WriteLine("Нажмите любую клавишу для просмотра.....");

            RunImagesModule.RunImages("2_1.png", FileByte2);
            MenuModule.menu = "0";

        }

    }
}
