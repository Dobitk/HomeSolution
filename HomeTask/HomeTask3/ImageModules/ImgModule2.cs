using System;
using System.Collections.Generic;
using System.Text;
using HomeTask3.CustomModules;

namespace HomeTask3.ImageModules
{
    class ImgModule2
    {
        public static void Runimg2()
        {
            var FileByte1 = Properties.Resources._2_1;
            var FileByte2 = Properties.Resources._2_2;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"1) Переходим в нужную папку, для создания локального репозитория");
            Console.WriteLine(@"   ""cd Путь к папке"" (с обратным < / > слешем)");
            Console.WriteLine(@"2) Создаем локальный репозиторий, командой ""git init""");
            Console.WriteLine(@"3) Добовляем файлы, командой ""git add . "" или ""git add <имя файла> """);
            Console.WriteLine(@"4) Можем посмотреть состояние, командами ""git status . "" и ""git log """);
            Console.WriteLine(@"5) Делаем commit, командой ""git commit -m <Имя комита> """);
            Console.WriteLine(@"6) Добавим ссылку на удаленный репозиторий, командой" );
            Console.WriteLine(@"   ""git remote add origin https://github.com/Dobitk/HomeSolution.git """);
            Console.WriteLine(@"7) Теперь привязываем локальный репозиторий с удаленным, командой");
            Console.WriteLine(@"   ""git push -u origin <Имя ветки> """);
            Console.WriteLine(@"8) Потом, каждый раз при следующих обновлениях репозитория, вводим только команду ");
            Console.WriteLine(@"   ""git push""");
            Console.WriteLine(Environment.NewLine);
  

            Console.WriteLine("Нажмите любую клавишу для просмотра.....");
            
            Console.ReadLine();
            RunImagesModule.RunImages("2_1.png", FileByte1);

            
            Console.WriteLine("Нажмите любую клавишу для просмотра.....");

            RunImagesModule.RunImages("2_1.png", FileByte2);
            MenuModule.menu = "0";

        }

    }
}
