using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestHello
{
    public class Greeting
    {
        public int Markets;
        public int EggShops;
        
        public void SetShops(int eggsh)
        {
            EggShops = eggsh;
        }

        public void SetMarkets(int mkts)
        {
            Markets = mkts;
        }

        public int GetShops()
        {
            return EggShops * Markets;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
         
            Greeting g1 = new Greeting();
            Greeting g2 = new Greeting();

            g1.SetMarkets(10);
            g1.SetShops(15);

            g2.SetMarkets(19);
            g2.SetShops(22);

            n1=g1.GetShops();
            n2=g2.GetShops();

            Console.WriteLine("No of shops in market 1 : {0}", n1);
            Console.WriteLine("No of shops in market 2 : {0}", n2);
            Console.ReadLine();

        }
    }
}
