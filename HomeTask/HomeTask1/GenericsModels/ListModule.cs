using HomeTask1.CustomModules;
using System;
using System.Collections.Generic;
using HomeTask1.CollectionsModules;

namespace HomeTask1.GenericsModels
{
    class ListModule
    {
        public void ListGeneric()
        {
            Console.Title = "Домашнее задание по теме Generic < List <T> >";
            //================================================================================
            //        Создаем новый List<T>
            //================================================================================
            ColorModule.Colorconsole("Имеем List<T>", ConsoleColor.Magenta);
            Console.WriteLine("");

            List<int> listGenneric = new List<int>
            {10, 20, 30, 40, 50, 60, 70, 80, 90};

             ColorModule.Colorconsole("Выводим только значение < List<T> >", ConsoleColor.Green);
             foreach (var listitem in listGenneric)
             {
                 ColorModule.Colorconsole(listitem, ConsoleColor.Gray);
             }

             Console.WriteLine(Environment.NewLine);

             //================================================================================
             //        Добовляем в средину число 65 по индексу, методом < Insert(index, value >
             //================================================================================
             ColorModule.Colorconsole("Добовляем в средину число 65 по индексу, методом < Insert(index, value >", ConsoleColor.Green);

             var ListTemp = new List<int>(listGenneric);

             ListTemp.Insert(6, 65);
             
             ListOutModule.AllOutForeach(ListTemp);

             Console.WriteLine(Environment.NewLine);

            //================================================================================
            //        Удаляем число 65 по индексу, методом < RemoveAt(index) >
            //================================================================================
            ColorModule.Colorconsole("Добовляем в средину число 65 по индексу, методом < Insert(index, value >", ConsoleColor.Green);


             ListTemp.RemoveAt(6);

             ListOutModule.AllOutForeach(ListTemp);

             Console.WriteLine(Environment.NewLine);

            //================================================================================
            //          Удаление элемента по значению
            //================================================================================

             ListTemp = new List<int>(listGenneric);

             ListTemp.Remove(70);//Удаляем элемент по значению

             ColorModule.Colorconsole("Удаляем число < 70 > из середины списка по значению. Методом < Remove(value) >", ConsoleColor.Green);

             ListOutModule.AllOutForeach(ListTemp);
             Console.WriteLine(Environment.NewLine);



             Console.WriteLine("Нажмите любую клавишу для выхода.....");
             MenuModule.menu = "0";
             Console.ReadLine();
             

        }


    }
}
