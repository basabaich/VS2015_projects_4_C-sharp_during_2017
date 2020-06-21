using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathFunctions
{
    class Program
    {
        public class AddClass
	  {
	    public static int Add(int a, int b)
	    {
	      return (a+b);
	    }
	  }

        public class MultiClass
	  {
	    public static int Multiply(int a, int b)
	    {
	      return (a* b);
	    }
        }


        public class FactorialClass
	  {
	    public static int Factorial(int i)
	    {
	      return((i <= 1) ? 1 : (i* Factorial(i-1)));
	    }
	 
	  }


        static void Main(string[] args)
        {

        }

    }

}
