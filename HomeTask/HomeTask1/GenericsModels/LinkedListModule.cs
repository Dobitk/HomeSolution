using HomeTask1.CollectionsModules;
using HomeTask1.CustomModules;
using System;
using System.Collections.Generic;

namespace HomeTask1.GenericsModels
{
    class LinkedListModule
    {


        public void linkedList()
        {



            Console.Title = "Домашнее задание по теме Generic < LinkedList <T> >";
            //================================================================================
            //        Создаем новый LinkedList<T> городов 
            //================================================================================
            ColorModule.Colorconsole("Имеем LinkedList<T> городов" , ConsoleColor.Magenta);
            Console.WriteLine("");

            LinkedList<string> Linkedlist = new LinkedList<string>();
            Linkedlist.AddFirst( "Gomel" );
            Linkedlist.AddAfter(Linkedlist.Last, "Rechitsa" );
            Linkedlist.AddAfter(Linkedlist.Last, "Loev");
            Linkedlist.AddAfter(Linkedlist.Last, "Bragin");
            Linkedlist.AddAfter(Linkedlist.Last, "Khoiniki");
            Linkedlist.AddAfter(Linkedlist.Last, "Vasilevichi");
            Linkedlist.AddAfter(Linkedlist.Last, "Gantsevichi");
            Linkedlist.AddAfter(Linkedlist.Last, "Drogichin");
            Linkedlist.AddAfter(Linkedlist.Last, "Zhabinka");
            Linkedlist.AddAfter(Linkedlist.Last, "Kletsk");
            Linkedlist.AddLast( "Lepel");


            LinkedListNode<string> Linkedlistnode = Linkedlist.First;

            while (Linkedlistnode != null)

            {
                if (Linkedlistnode != null)
                {
                  ColorModule.Colorconsole(Linkedlistnode.Value, ConsoleColor.Gray);
                  Linkedlistnode = Linkedlistnode.Next;

                }
            }
            Console.WriteLine(Environment.NewLine);
            //================================================================================
            //     Поиск и удаление элемента 
            //================================================================================
            ColorModule.Colorconsole("Удаление элемента < Vasilevichi >, методам поиска< Find(value) >  и удаления < Remove(node) >", ConsoleColor.Green);
            var node = Linkedlist.Find("Vasilevichi");


            if (node != null)
            {
                Linkedlist.Remove(node);
            }
            else
            {
                ColorModule.Colorconsole("Такой элемент со значением < Vasilevichi >, не найден.", ConsoleColor.Red);
            }

            ListOutModule.AllOutForeach(Linkedlist);

            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //     Поиск и удаление элемента 
            //================================================================================
            ColorModule.Colorconsole("Удаление элемента в начале < RemoveFirst() >", ConsoleColor.Green);

            Linkedlist.RemoveFirst();

            ListOutModule.AllOutForeach(Linkedlist);

            Console.WriteLine(Environment.NewLine);




            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            MenuModule.menu = "0";
            Console.ReadLine();

        }


    }
}
