using System;
using HomeTask5_2.CommonModules;
using HomeTask5_2.UserClassModules;

namespace HomeTask5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создайте класс Country, этот класс должен содержать, " +
                              "как минимум, одно свойство - типа District."+
                              "District - пользователький(который вы создали сами) " +
                              "класс, в котором, как минимум, должно быть одно свойство - типа City."+
                              "City - пользовательский класс, в котором, как минимум, должно " +
                              "быть одно свойство - типа Neighborhood."+
                              "Neighborhood - пользовательский класс, в котором должны быть свойства " +
                              "StreetName и HouseNumber."+
                              "Создайте коллекцию элементов Country, заполните ее несколькими значениями."+
                              "С помощью запроса LINQ из коллекции Стран сформируйте коллекцию всех имен улиц(StreetName), " +
                              "которые встречаются в коллекции Стран.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Нажмите любую клавишу для продолжения.......");

            Console.Read();
            RunBase.Runbase();
        }
    }
}
