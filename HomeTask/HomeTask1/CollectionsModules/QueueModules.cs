using HomeTask1.CustomModules;
using System;
using System.Collections;

namespace HomeTask1.CollectionsModules
{
    class QueueModules
    {

        public void QueueList()
        {
            Console.Title = "Домашнее задание по теме Collection < Queue >";


        //================================================================================
        // 
        //================================================================================

            string s = "Работа с методами в Queue";
            ColorModule.Colorconsole(s, ConsoleColor.Cyan);

            //================================================================================
            //        Создаем новую очередь и добовляе элементы
            //================================================================================
            ColorModule.Colorconsole("Имеем Queue чисел", ConsoleColor.Magenta);
            Console.WriteLine("");
            Queue queueList = new Queue();
        
            queueList.Enqueue(10);
            queueList.Enqueue(20);
            queueList.Enqueue(30);
            queueList.Enqueue(40);
            queueList.Enqueue(50);
            queueList.Enqueue(60);
            queueList.Enqueue(70);
            queueList.Enqueue(80);
            queueList.Enqueue(90);



            ListOutModule.AllOutForeach(queueList);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //   Удаление первого элемента из очереди, методом < Dequeue() >  
            //================================================================================

            ColorModule.Colorconsole("Удаление первого элемента из очереди, методом < Dequeue() >", ConsoleColor.Green);
            var QueueTemp = (Queue)queueList.Clone();
            QueueTemp.Dequeue();

            ListOutModule.AllOutForeach(QueueTemp);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //   Узнае сколько элементов в очереди
            //================================================================================

            ColorModule.Colorconsole("Узнаем сколько элементов в очереди , методом < Count >", ConsoleColor.Green);

            QueueTemp.Clear();
            QueueTemp = (Queue)queueList.Clone();
            var count = QueueTemp.Count;


            ListOutModule.AllOutForeach(QueueTemp);
            ColorModule.Colorconsole("Элементов в очереди - " + count, ConsoleColor.Yellow);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //    Получить первый элемент в очереди
            //================================================================================

            ColorModule.Colorconsole("Получаем первый элемент в очереди , методом < Peek() >", ConsoleColor.Green);

            QueueTemp.Clear();
            QueueTemp = (Queue)queueList.Clone();
            var peek = QueueTemp.Peek();


            ListOutModule.AllOutForeach(QueueTemp);

            ColorModule.Colorconsole("Первый элемент в очереди - " + peek, ConsoleColor.Yellow);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            MenuModule.menu = "0";
            Console.ReadLine();


        }



    }
}
