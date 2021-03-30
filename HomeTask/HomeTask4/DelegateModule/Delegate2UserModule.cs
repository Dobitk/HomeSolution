using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.DelegateModule
{
    class Delegate2UserModule
    {

        delegate void Delegate2(int X, int Y);

        User2Module user2 = new User2Module();

        Delegate2 deleg = User2Module.OutDelegate2;


        public void sdDelegate(int x, int y)
        {
            user2.X = x;
            user2.Y = y;
            deleg(user2.X, user2.Y);

        }





    }
}
