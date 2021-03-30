using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.DelegateModule
{
   
    public class User1Module
    {
      public string Name { get; set; }

      public static void OutDelegate1()
      {

          User1Module user1 = new User1Module();
          user1.Name = "Первый делегат запущен.";

          Console.WriteLine("Delegate1().   " + user1.Name);
          Console.WriteLine(Environment.NewLine);
      }
 

    }

}
