using HomeTask1.CustomModules;
using System;
using System.Collections;

namespace HomeTask1.CollectionsModules
{
    class StackModules
    {
        class Person
        {
            public  string FirstName { get; set; }
        }

        public void StackList()
        {
            Console.Title = "Домашнее задание по теме Collection < Stack >";


            //================================================================================
            // 
            //================================================================================

            string s = "Работа с методами в Stack";
            ColorModule.Colorconsole(s, ConsoleColor.Cyan);
            

            //================================================================================
            //        Создаем новый стэк и добовляе элементы
            //================================================================================
            ColorModule.Colorconsole("Имеем Stack имен", ConsoleColor.Magenta);
            Console.WriteLine("");

            Stack stackList = new Stack();
            
            stackList.Push(new Person() { FirstName = "Boris" });
            stackList.Push(new Person() { FirstName = "Oleg" });
            stackList.Push(new Person() { FirstName = "Alecsandr" });
            stackList.Push(new Person() { FirstName = "Mihail" });
            stackList.Push(new Person() { FirstName = "Robert" });

            foreach (Person stackitem in stackList)
            {
                ColorModule.Colorconsole(stackitem.FirstName, ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //       Узнае сколько элементов в стеке
            //================================================================================

            var count = stackList.Count;

            ColorModule.Colorconsole("Узнаем сколько элементов в очереди , методом < Count >", ConsoleColor.Green);

            foreach (Person stackitem in stackList)
            {
                ColorModule.Colorconsole(stackitem.FirstName, ConsoleColor.Gray);
            }
            ColorModule.Colorconsole("Элементов в очереди - " + count, ConsoleColor.Yellow);
            Console.WriteLine(Environment.NewLine);

            //================================================================================
            //        Получить первый элемент в стеке
            //================================================================================
            Person peek = (Person)stackList.Peek();

            ColorModule.Colorconsole("Получаем первый элемент в очереди , методом < Peek() >", ConsoleColor.Green);

            foreach (Person stackitem in stackList)
            {
                ColorModule.Colorconsole(stackitem.FirstName, ConsoleColor.Gray);
            }
            ColorModule.Colorconsole("Первый элемент в очереди - " + peek.FirstName, ConsoleColor.Yellow);
            Console.WriteLine(Environment.NewLine);


            //================================================================================
            //       Удаление первого элемента в стеке
            //================================================================================


            stackList.Pop();

            ColorModule.Colorconsole("Удаление первого элемента в стеке, методом < Pop() >.", ConsoleColor.Green);

            foreach (Person stackitem in stackList)
            {
                ColorModule.Colorconsole(stackitem.FirstName, ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);




            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            MenuModule.menu = "0";
            Console.ReadLine();


        }
    }
}
