using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4.EventsModule
{
    public delegate void D1();

    class Cat
    {

        public event D1 WakeUpEvent;
        public void onWakeUpEvent()
        {
            WakeUpEvent?.Invoke();

        }
    }
}
