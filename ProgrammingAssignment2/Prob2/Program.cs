/*
Author: Torin Tashima
Date:   10/13/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 2

   Methods

1. Create a method that demonstrates call by value
2. Create a method that demonstrates call by reference
3. Create methods that demonstrate overloading
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        // method for region 1 - call by value
        static void changeInt(int i)
        {
            i = 200;
            Console.WriteLine("\tNumber inside changeInt(): {0}", i);
        }

        // method for region 2 - call by reference
        static void changeIntRef(ref int i)
        {
            i = 200;
            Console.WriteLine("\tNumber inside changeIntRef(): {0}", i);
        }

        // method for region 3 - overloading
        static void myMethod(string str)
        {
            Console.WriteLine("\tString: myMethod(\"{0}\")", str);
        }

        // method for region 3 - overloading
        static void myMethod(int i)
        {
            Console.WriteLine("\tInteger: myMethod({0})", i);
        }

        static void Main(string[] args)
        {
            #region region 1 - call by value
            int myInt = 404;
            Console.WriteLine("Calling function by value...");

            Console.WriteLine("\tNumber before changeInt(): {0} ", myInt);
            changeInt(myInt);
            Console.WriteLine("\tNumber after changeInt(): {0} ", myInt);

            Console.WriteLine();
            #endregion

            #region region 2 - call by reference
            int myOtherInt = 404;
            Console.WriteLine("Calling function by reference...");

            Console.WriteLine("\tNumber before changeIntRef(): {0} ", myOtherInt);
            changeIntRef(ref myOtherInt);
            Console.WriteLine("\tNumber after changeIntRef(): {0} ", myOtherInt);

            Console.WriteLine();
            #endregion

            #region region 3 - overloading
            Console.WriteLine("Overloading - Function parameter is a(n)...");
            myMethod(1992);
            myMethod("weezer");
            #endregion
        }
    }
}
