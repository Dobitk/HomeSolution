using HomeTask3.CustomModules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeTask3.ImageModules
{
    class ImgModule1
    {
        public static void Runimg1()
        {
            var FileByte = Properties.Resources._1_1;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Меняем текстовый редактор на Notepad++.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"git config--global core.editor ""C:\Program Files (x86)\Notepad++\notepad++.exe""");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Нажмите любую клавишу для просмотра .....");
            Console.Read();

            RunImagesModule.RunImages("1.png", FileByte);
            MenuModule.menu = "0";

            
        }
    }
}
