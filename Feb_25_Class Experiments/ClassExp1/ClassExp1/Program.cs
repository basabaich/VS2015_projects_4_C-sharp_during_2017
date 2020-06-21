using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExp1
{
    partial class BoxCalculation
    {
        // define variables
        double Length;
        double Breadth;
        double Height;


        // method for defining the variables
        public void SetBoxCalc(double len, double bre, double hei)
        {           
            Length = len;
            Breadth = bre;
            Height = hei;
        }

        // get the volume of box
        public double GetVol()
        {
            return Length * Breadth * Height;
        }

        // get the area of box
        public double GetArea()
        {
            double side1;
            double side2;
            double top;
            
            side1 = Length * Height *2;
            side2 = Breadth * Height * 2;
            top = Length * Breadth * 2;

            return side1 + side2 + top;

        }


    }

    class Program
    {        

        static void Main(string[] args)
        {
            // define variables to be used 
            double db1, db2;

            // define instance of the "BoxCalculation()" Class
            BoxCalculation bc = new BoxCalculation();

            // using Class instance we define the values in the 
            // method declared in "BoxCalculation()" Class
            bc.SetBoxCalc(10, 14, 24);

            // get volume of box
            db1=bc.GetVol();

            // get area of box
            db2=bc.GetArea();

            // display the values in the screen
            Console.WriteLine("volume of box : {0}", db1);
            Console.WriteLine("area of box : {0}", db2);
            Console.ReadLine();

        }
    }
}
