using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Timer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer Mytimer = new Timer();
            Mytimer.Interval = 5000;
            Mytimer.Start();

            
            
           
        }
    }
}
