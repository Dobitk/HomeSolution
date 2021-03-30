using System;
using HomeTask4.DelegateModule;
using HomeTask4.EventsModule;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("1. Создайте тип делегата, тип возвращаемого значения которого"+
                              " будет созданный вами пользовательский класс. В созданном вами "+
                              "класса создайте метод, который будет выводить строку в консоль и "+
                              "соотвествующий тип делегата для этого метода. (Условие запутанное. Как понял так и написал.)");
            Console.WriteLine(Environment.NewLine);
            Delegate1UserModule.sdDelegate(); 

            Delegate2UserModule Startdelegate2 = new Delegate2UserModule();
            Startdelegate2.sdDelegate(10,2);
            Console.WriteLine(Environment.NewLine);

//===================================================================================================================================
            Console.WriteLine("2. Обьявите обобщенный тип делегата с одним входящим " +
                              "параметром, возвращаемый тип и тип параметра должны опеределятся " +
                              "во время создания делегата разными PLACEHOLDER`ами. Задайте действия " +
                              "делегата лямбда выражением и вызовите делегат.");
            Console.WriteLine(Environment.NewLine);

            RunDelegate.RunDelegate1(25);
            RunDelegate.RunDelegate1(2545646546152659);
            RunDelegate.RunDelegate1(3.14);
            RunDelegate.RunDelegate1(true);
            RunDelegate.RunDelegate1("Строковое значение");
            Console.WriteLine(Environment.NewLine);
            //===================================================================================================================================

            Console.WriteLine("3. Создайте класс Cat и обьявите в нем событие WakeUpEvent. " +
                              "Создайте классы подписчики Dog, Mouse, Human. Подпишитесь в " +
                              "этих классах на событие WakeUpEvent и пропишите с помощью " +
                              "вывода в консоль что должны делать каждый из классов " +
                              "подписчиков когда происходит событие.");
            Console.WriteLine(Environment.NewLine);

            Dog.Dogs();
            Console.WriteLine(Environment.NewLine);
            Mouse.Mouses();
            Console.WriteLine(Environment.NewLine);
            Human.Humans();

        }
    }
}
