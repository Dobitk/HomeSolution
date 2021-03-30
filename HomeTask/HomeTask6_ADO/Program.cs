using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask6_ADO.UserModule;

namespace HomeTask6_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            GreateStories.CreateTable();
            InsertStories.InsertValues();
            SelectStories.SelectTable();

        }
    }
}
