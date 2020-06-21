using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSeller
{
    public class Greeting
    {

        public int Markets;
        public int EggShops;
        public int SellersPerShop;


        public void SetMarkets(int mkts)
        {
            Markets = mkts;
        }

        public void SetShops(int eggsh)
        {
            EggShops = eggsh;
        }

        public void SetSellersPerShop(int selrs)
        {
            SellersPerShop = selrs;
        }

        public int GetSellers()
        {
            return Markets * EggShops * SellersPerShop;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, TotalSellers;

            Greeting g1 = new Greeting();
            Greeting g2 = new Greeting();

            g1.SetMarkets(10);
            g1.SetShops(15);
            g1.SetSellersPerShop(2);

            g2.SetMarkets(19);
            g2.SetShops(22);
            g2.SetSellersPerShop(3);

            n1 = g1.GetSellers();
            n2 = g2.GetSellers();
            TotalSellers = n1 + n2;

            Console.WriteLine("Total no of sellers in all shops in all markets : {0}", TotalSellers);
            Console.ReadLine();

        }
    }
}


