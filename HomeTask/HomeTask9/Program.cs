using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;
using HomeTask9.UserAttributes;

namespace HomeTask9
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo fileinfo = new FileInfo(@"D:\Temp\MyFile.txt");
            try
            {
                fileinfo.Create();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\TEMP");

                Console.WriteLine("Создаем директорию D:\\TEMP");
                directoryInfo.Create();

                if (directoryInfo.Exists)
                {
                    Console.WriteLine("Директория создана");
                }
                else
                {
                    Console.WriteLine("Директория не создана");
                }

                

                Console.WriteLine("Создаем файл D:\\Temp\\MyFile.txt");
                fileinfo.Create();

                if (fileinfo.Exists)
                {
                    Console.WriteLine("Файл создан");
                }
                else
                {
                    Console.WriteLine("Файл не создан");
                }
                
            }

            Console.WriteLine(Environment.NewLine);
            AttributeRun.Runattribute();



        }
    }
}
