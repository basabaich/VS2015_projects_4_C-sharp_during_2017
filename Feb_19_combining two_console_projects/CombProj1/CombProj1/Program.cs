using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CombProj1
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            double x1, y1;

            TestSeller.Greeting sg = new TestSeller.Greeting();
            TestHello.Greeting hg = new TestHello.Greeting();

            hg.SetMarkets(9);
            hg.SetShops(23);
            sg.SetMarkets(9);
            sg.SetShops(22);
            sg.SetSellersPerShop(3);

            x1=hg.GetShops();
            y1=sg.GetSellers();

            Console.WriteLine("total no of shops : {0}", x1);
            Console.WriteLine("total no of sellers : {0}", y1);
            Console.ReadLine();
            
        }
    }
}
