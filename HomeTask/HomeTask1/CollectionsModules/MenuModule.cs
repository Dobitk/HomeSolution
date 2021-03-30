using HomeTask1.GenericsModels;
using System;
using HomeTask1.CustomModules;

namespace HomeTask1.CollectionsModules
{
    class MenuModule
    {
        public static string menu = "0";
        public static void MenuOut()
        {
 
            while (menu != "9")
            {

                switch (menu)
                {
                    case "0":
                    {

                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                     Коллекции");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                1. Методы ArrayList");
                        Console.WriteLine("                                2. Методы Stack");
                        Console.WriteLine("                                3. Методы Queue");
                        Console.WriteLine("                                4. Методы Hashtable");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                     Обобщения");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                5. Методы List<T>");
                        Console.WriteLine("                                6. Методы LinkedList<T>");
                        Console.WriteLine("                                7. Методы Dictionary<IKey, IValue>");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("                                9. Выход");
                        
                            menu = Console.ReadLine();

                            if ((Convert.ToInt32(menu) == 8) ||  (Convert.ToInt32(menu) >= 10))
                            {
                                Console.Clear();
                                menu = "0";
                            }

                            break;

                    }

                    case "1":
                    {
                        Console.Clear();
                        ArrayListModule arrayListModule = new ArrayListModule();
                        arrayListModule.listArray();
                        Console.Clear();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        StackModules stackList = new StackModules();
                        stackList.StackList();
                        Console.Clear();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        QueueModules Queuelist = new QueueModules();
                        Queuelist.QueueList();
                        Console.Clear();
                        break;
                    }

                    case "4":
                    {
                        Console.Clear();
                        HashModule hashlist = new HashModule();
                        hashlist.HashList();
                        Console.Clear();
                        break;
                    }
                    case "5":
                    {
                        Console.Clear();
                        ListModule Listlist = new ListModule();
                        Listlist.ListGeneric();
                        Console.Clear();
                        break;
                    }
                    case "6":
                    {
                        Console.Clear();
                        LinkedListModule Lingedlist = new LinkedListModule();
                        Lingedlist.linkedList();
                        Console.Clear();
                        break;
                    }
                    case "7":
                    {
                        Console.Clear();
                        DictionaryModule dictinaryList = new DictionaryModule();
                        dictinaryList.DictionaryList();
                        Console.Clear();
                        break;
                    }


                        //case "5":
                        //{
                        //    menu = "5";
                        //    break;
                        //}





                }








            }


        }
    }
}
