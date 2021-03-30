using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using HomeTask1.CustomModules;

namespace HomeTask1.CollectionsModules
{
    class ArrayListModule
    {

        public void listArray()
        {
            Console.Title = "Домашнее задание по теме Collection < ArrayList >"; 
            //================================================================================
            //  Создаем список 
            //================================================================================

            string s = "Работа с методами в ArrayList";
            ColorModule.Colorconsole(s, ConsoleColor.Cyan);
            ColorModule.Colorconsole("Имеем ArrayList городов", ConsoleColor.Magenta);
            Console.WriteLine("");

            ArrayList arrayList = new ArrayList
            {
                "Minsk",
                "Gomel",
                "Brest",
                "Grodno",
                "Loev",
                "Bragin"
            };

            //================================================================================
            //                              1. Способ.
            //       Выводим  в консоль созданный список с помощью оператора foreach
            //================================================================================

            ColorModule.Colorconsole("Используем оператор FOREACH для вывода коллекции", ConsoleColor.Green );

            foreach (var Listitem in arrayList)
            {
                ColorModule.Colorconsole(Listitem, ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //                              2. Способ.
            //       Выводим  в консоль созданный список с помощью оператора for
            //================================================================================

            ColorModule.Colorconsole("Используем оператор FOR для вывода коллекции", ConsoleColor.Green);

            for (int i = 0; i < arrayList.Count; i++)
            {
                ColorModule.Colorconsole(arrayList[i], ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //          Удаление элемента по значению
            //================================================================================

            var Arraylist = new ArrayList(arrayList);

            Arraylist.Remove("Grodno");//Удаляем элемент по значению

            ColorModule.Colorconsole("Удаляем город < Grodno > из середины списка по значению. Методом < Remove(value) >", ConsoleColor.Green);

            ListOutModule.ArrayListOutForeach(Arraylist);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //          Удаление элемента по индексу
            //================================================================================
            Arraylist.Clear();
            Arraylist = new ArrayList(arrayList);

            Arraylist.RemoveAt(4);//Удаляем элемент по индексу

            ColorModule.Colorconsole("Удаляем город из середины списка по индексу < 4 > со знчением < Loev >. Методом < RemoveAt(index) >", ConsoleColor.Green);

            ListOutModule.ArrayListOutFor(Arraylist);
            Console.WriteLine(Environment.NewLine);


            //================================================================================
            //        Проверяем на дублирование элементов в списке 
            //        Если элемент существует
            //================================================================================

            Arraylist.Clear();
            Arraylist = new ArrayList(arrayList);
            ColorModule.Colorconsole("Проверяем на дублирование элементов в списе, с помощью метода < IndexOf(value) >", ConsoleColor.Green);
            ColorModule.Colorconsole("Добавим город < Grodno >", ConsoleColor.Green);

            if (Arraylist.IndexOf("Grodno") != -1)
            {
                ListOutModule.ArrayListOutForeach(Arraylist);
                ColorModule.Colorconsole("Такой город < Grodno >, существует в списке", ConsoleColor.Red);
            }

           

            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //          Если элемента нет в списке
            //================================================================================

            Arraylist.Clear();
            Arraylist = new ArrayList(arrayList);
           ColorModule.Colorconsole("Теперь добавим город < Svetlogorsk >", ConsoleColor.Green);

            if (Arraylist.IndexOf("Svetlogorsk") == -1)
            {
                Arraylist.Add("Svetlogorsk");
                ListOutModule.ArrayListOutForeach(Arraylist);
                ColorModule.Colorconsole("Такого города нет.", ConsoleColor.Yellow);
                ColorModule.Colorconsole("Добавили его с помощью метода < Add >", ConsoleColor.Yellow);
                
            }

            
            Console.WriteLine(Environment.NewLine);


            //================================================================================
            //          Добовление элемента в средину списка
            //================================================================================
            Arraylist.Clear();
            Arraylist = new ArrayList(arrayList);
            ColorModule.Colorconsole("Добавим город < Novopolotsk > в средину списка по индексу < 2 >, с помощью метода < Insert(index,value) >.", ConsoleColor.Green);

            Arraylist.Insert(2, "Novopolotsk");

            ListOutModule.ArrayListOutForeach(Arraylist);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //          Отсортируем список
            //================================================================================
            Arraylist.Clear();
            Arraylist = new ArrayList(arrayList);
            ColorModule.Colorconsole("Отсортируем список, с помощью метода < Sort() >.", ConsoleColor.Green);

            Arraylist.Sort();
            ListOutModule.ArrayListOutForeach(Arraylist);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            MenuModule.menu = "0";
            Console.ReadLine();

        }

    }
}
