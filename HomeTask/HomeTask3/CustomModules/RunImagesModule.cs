using System;
using System.Diagnostics;
using System.IO;

namespace HomeTask3.CustomModules
{
    class RunImagesModule
    {
        public static void RunImages( string name, byte[] nameres)
        {
            File.WriteAllBytes(name, nameres);
            var p = new Process
            {
                StartInfo = new ProcessStartInfo(name)
                {
                    UseShellExecute = true
                }
            };
            p.Start();

            Console.Read();
 
        //    
            
        }
    }
}
