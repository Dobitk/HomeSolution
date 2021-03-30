using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Text;
using HomeTask9.UserAttributes;

namespace HomeTask9
{
    class AttributeRun
    {
        
        [UserAtt(5)]
       
        public static void Attribute1()
        {

        }



        [UserAtt("Display Name")]
        public static void Attribute2()
        {

        }

        public static void Runattribute()
        {

            var method = Type.GetType("HomeTask9.AttributeRun").GetMethod("Attribute1").GetCustomAttributes();

            foreach (var itemattribute in method)
            {
                Console.WriteLine("{0}", itemattribute.GetType().Name);
            }
            Console.WriteLine(Environment.NewLine);


            method = Type.GetType("HomeTask9.AttributeRun").GetMethod("Attribute2").GetCustomAttributes();

            foreach (var itemattribute in method)
            {

                Console.WriteLine("{0}", itemattribute.GetType().Name);
            }

        }
    }
}
