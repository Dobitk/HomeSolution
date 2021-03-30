using System;
using System.Collections.Generic;
using System.Text;
using HomeTask4.DelegateModule;

namespace HomeTask4.DelegateModule
{


    public static class  Delegate1UserModule
    {

        delegate void Delegate1();

        public static void sdDelegate()
        {
            
 
            Delegate1 delegate1 = User1Module.OutDelegate1;
            delegate1();

        }

    }

}


