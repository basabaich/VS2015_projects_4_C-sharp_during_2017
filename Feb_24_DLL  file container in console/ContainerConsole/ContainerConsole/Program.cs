using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib1;

namespace ContainerConsole
{
    

    class DllRun
    {
      
        static void Main(string[] args)
        {
            calculation cal = new calculation();

            
            int i = cal.Add(23, 37);
            int i2 = cal.Sub(28, 12);

            Console.WriteLine("addition result is : {0}", i);
            Console.WriteLine("substruction result is : {0}", i2);
            Console.ReadLine();

        }
    }
}
