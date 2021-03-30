using System;
using System.Collections.Generic;
using System.Text;
using HomeTask3.ImageModules;

namespace HomeTask3
{
    class MenuModule
    {
        public static string menu = "0";

        public static void MenuGit()
        {

            while (menu != "4")
            {

                switch (menu)
                {
                    case "0":
                    {

                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                     Git Bush");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                1. Меняем редактор по умолчанию в Git Bush");
                        Console.WriteLine("                                2. Создаем репозиторий");
                        Console.WriteLine("                                3. Клонирование репозитория");
                            Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                4. Выход");

                        menu = Console.ReadLine();

                            if ((Convert.ToInt32(menu) >= 5) || (menu == ""))
                            {
                                Console.Clear();
                                menu = "0";
                            }

                            break;

                    }
                    case "1":
                    {
                        Console.Clear();
                        ImgModule1.Runimg1();
                        Console.Clear();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        ImgModule2.Runimg2();
                        Console.Clear();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        ImgModule3.Runimg3();
                        Console.Clear();
                        break;
                    }

                }
            }
        }

    }
}
