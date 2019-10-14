/*
Author: Torin Tashima
Date:   10/13/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 1

   Arrays

1. Create an array of strings
    - Strings should contain the words "one" to "ten"
    - Initialize using the initialization syntax
    - Print using a foreach loop
2. Create an array of ints
    - Array must be size 10
    - Initialize using a for loop
    - Array should contain the indices multiplied by 10 (0, 10, 20...)
    - Print using a for loop
3. Create a 2d array
    - Should form a 12x12 multiplication table
    - Print in a neat, orderly way
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region 1 - array of strings
            // initialization syntax
            string[] strArray = new string[] {"one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine", "ten"};

            // print results
            Console.Write("String Array: ");
            foreach (string str in strArray)
            {
                Console.Write("{0} ", str);
            }
            Console.WriteLine();
            #endregion

            #region region 2 - array of ints
            int[] intArray = new int[10];

            // initialization using for loop
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 10;
            }

            // print results
            Console.Write("Int Array: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
            Console.WriteLine();
            #endregion

            #region region 3 - multiplication table
            int[,] timesTable = new int[12, 12];

            // initialization using nested for loops
            for (int row = 0; row < timesTable.GetLength(0); row++)
            {
                for (int col = 0; col < timesTable.GetLength(1); col++)
                {
                    timesTable[row, col] = (row + 1) * (col + 1);
                }
            }

            // print results
            // print header
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t12x12 Multiplication Table");
            Console.WriteLine();
            Console.Write("\t");
            for (int col = 0; col < timesTable.GetLength(1); col++)
            {
                Console.Write("{0}\t", timesTable[0, col]);
            }
            Console.WriteLine();

            Console.Write("\t");
            for (int col = 0; col < timesTable.GetLength(1); col++)
            {
                Console.Write("--------");
            }
            Console.WriteLine();

            // print table
            for (int row = 0; row < timesTable.GetLength(0); row++)
            {
                // alternate background colors per row
                if (row % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.Write("{0, 3}  |\t", timesTable[row, 0]);
                for (int col = 0; col < timesTable.GetLength(1); col++)
                {
                    Console.Write("{0}\t", timesTable[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
        }
    }
}
