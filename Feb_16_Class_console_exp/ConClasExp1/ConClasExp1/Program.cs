using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConClasExp1
{

    

    class Box
    {
        double Length;
        double Breadth;
        

        public void SetLength(double len)
        {
             Length = len;
        }

        public void SetBreadth(double brdt)
        {
            Breadth = brdt;
        }

        public double GetArea(double area)
        {
            area = Length * Breadth;
            return area;
        }

        public double GetCircumference()
        {
           // double Circum;
            return ((2 * Length) + (2 * Breadth));
        }

        public double GetHalfArea()
        {
            //double halfArea;
            return (Length * Breadth) / 2;
        }

        public void GetHalfBoundary(double halfBound)
        {
            //double halfBound;
            halfBound = (Length + Breadth);
            return halfBound;

        }


    }

   

    class Program
    {
       

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world !");
            //Console.ReadLine();

            double xx;
            double ar;
            double rslt;
            double circ;
            double hfbnd;

            Box b1 = new Box();
            Box b2 = new Box();

            b1.SetLength(19);
            b1.SetBreadth(12);

            
            circ = b1.GetCircumference();
            ar = b1.GetHalfArea();
            hfbnd = b1.GetHalfBoundary(xx);

            Console.WriteLine("circumference is : {0}", circ);
            Console.WriteLine("Area is : {0}", ar);
            Console.ReadLine();

            
        }
    }
}
