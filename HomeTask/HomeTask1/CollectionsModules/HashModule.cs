using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HomeTask1.CustomModules;

namespace HomeTask1.CollectionsModules
{

 
    class HashModule
    {

        public void HashList()
        {
            Console.Title = "Домашнее задание по теме Collection < Queue >";
            //================================================================================
            //        Создаем новую хэш-таблицу и добовляе ключ-значения
            //================================================================================
            ColorModule.Colorconsole("Имеем Hashtable", ConsoleColor.Magenta);
            Console.WriteLine("");
            Hashtable hashList = new Hashtable();

            hashList.Add(1, "Bobruisk");
            hashList.Add(2, "Mogilev");
            hashList.Add(3, "Chechersk");
            hashList.Add(4, "Svetlogorsk");
            hashList.Add(5, "Uzda");
            
            ColorModule.Colorconsole("Выводим только значение Key, методом < Keys >", ConsoleColor.Green);
            foreach (var hashitem  in hashList.Keys)
            {
                ColorModule.Colorconsole("Key : "+hashitem, ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);

            ColorModule.Colorconsole("Выводим только значение Value, методом < Values >", ConsoleColor.Green);


            foreach (var hashitem in hashList.Values)
            {
                ColorModule.Colorconsole("Value : " + hashitem, ConsoleColor.Gray);
            }
            Console.WriteLine(Environment.NewLine);

            ColorModule.Colorconsole("Выводим КЛЮЧ-ЗНАЧЕНИЕ", ConsoleColor.Green);
            ColorModule.Colorconsole( "Key : Value", ConsoleColor.Cyan);
            
            ListOutModule.HashOutForeach(hashList);
            Console.WriteLine(Environment.NewLine);


            //================================================================================
            //       Удаление хэш записей по ключу 
            //================================================================================
            ColorModule.Colorconsole("Удаление хэш-записеи по ключу < 4 >", ConsoleColor.Green);
            ColorModule.Colorconsole("Key : Value", ConsoleColor.Cyan);


            Hashtable HashTemp = (Hashtable)hashList.Clone();

            HashTemp.Remove(4);

            ListOutModule.HashOutForeach(HashTemp);
            Console.WriteLine(Environment.NewLine);


            //================================================================================
            //       Добовляем значение  
            //================================================================================
            ColorModule.Colorconsole("Добавим хэш-значение < Key=4, Value=Svetlogorsk >", ConsoleColor.Green);
            ColorModule.Colorconsole("Key : Value", ConsoleColor.Cyan);

            HashTemp.Clear();
            HashTemp = (Hashtable)hashList.Clone();

            try
            {
                HashTemp.Add(4, "Svetlogorsk");
            }
            catch
            {
                ListOutModule.HashOutForeach(HashTemp);
                ColorModule.Colorconsole("Такое хэщ-значение есть.", ConsoleColor.Red);

            }
          
            Console.WriteLine("Нажмите любую клавишу для выхода.....");
            MenuModule.menu = "0";
            Console.ReadLine();

        }

    }
}
