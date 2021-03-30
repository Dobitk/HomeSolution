using HomeTask1.CustomModules;
using HomeTask1.GenericsModels.ClassInterfaces;
using HomeTask1.GenericsModels.Interface;
using System;
using System.Collections.Generic;
using HomeTask1.CollectionsModules;

namespace HomeTask1.GenericsModels
{
    class DictionaryModule
    {

        public void DictionaryList()
        {
            Console.Title = "Домашнее задание по теме Generic < Dictionary < TKey, TValue> >";
            //================================================================================
            //        Создаем новый Dictionary <TKey, TValue> имен
            //================================================================================
            ColorModule.Colorconsole("Имеем Dictionary <TKey, TValue> городов", ConsoleColor.Magenta);
            Console.WriteLine("");
            ColorModule.Colorconsole("Dictionary < IKey, IValue >", ConsoleColor.Green);
            Dictionary<IKey, IValue> dictionary1 = new Dictionary<IKey, IValue>();

            dictionary1.Add(new DKey() {KeyD = 1}, new DValue() {ValueD = "Boris"});
            dictionary1.Add(new DKey() {KeyD = 2}, new DValue() {ValueD = "Sergei"});
            dictionary1.Add(new DKey() {KeyD = 3}, new DValue() {ValueD = "Mihail"});
            dictionary1.Add(new DKey() {KeyD = 4}, new DValue() {ValueD = "Natasha"});
            dictionary1.Add(new DKey() {KeyD = 5}, new DValue() {ValueD = "Dima"});
            dictionary1.Add(new DKey() {KeyD = 6}, new DValue() {ValueD = "Vlad"});




            foreach (KeyValuePair<IKey, IValue> item in dictionary1)
            {
                ColorModule.Colorconsole("  " + item.Key.KeyD + " : " + item.Value.ValueD, ConsoleColor.Gray);
            }

            Console.WriteLine(Environment.NewLine);


            Dictionary<IKey, IValue> dictionary2 = new Dictionary<IKey, IValue>();


            var valueKey1 = new FKey() {KeyD = 100};
            var valueKey2 = new FValue() {ValueD = "Smirnov"};
            var valueKey3 = new FKey() {KeyD =110};
            var valueKey4 = new FValue() {ValueD = "Kovalev"};
            var valueKey5 = new FKey() {KeyD = 120};
            var valueKey6 = new FValue() {ValueD = "Ivanov"};
            var valueKey7 = new FKey() { KeyD = 130 };
            var valueKey8 = new FValue() { ValueD = "Smirnov" };
            var valueKey9 = new FKey() { KeyD = 140 };
            var valueKey10 = new FValue() { ValueD = "Pupkin" };





            dictionary2.Add(valueKey1, valueKey2);
            dictionary2.Add(valueKey3, valueKey4);
            dictionary2.Add(valueKey5, valueKey6);
            dictionary2.Add(valueKey7, valueKey8); 
            dictionary2.Add(valueKey9, valueKey10);
  
            foreach (KeyValuePair<IKey, IValue> item in dictionary2)
            {
                ColorModule.Colorconsole("  " + item.Key.KeyD + " : " + item.Value.ValueD, ConsoleColor.Gray);
            }

            Console.WriteLine(Environment.NewLine);





                Console.WriteLine("Нажмите любую клавишу для выхода.....");
                MenuModule.menu = "0";
                Console.ReadLine();

           
        }
    }

}
