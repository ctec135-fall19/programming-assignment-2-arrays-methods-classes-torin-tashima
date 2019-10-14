/*
Author: Torin Tashima
Date:   10/13/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 3

   Classes

Create a Student class with the following:
    - A Name field along with the getter and setter
    - An ID property (throw exception if ID is outside the range of
        100000 to 999999)
    - An automatic property for GPA
    - Three constructors: master, default, and one that sets only name and id
    - A PrintState() method to print the student's information

In Main():
    - Use each of the three constructors
    - Use getter and setter for Name field
    - Use both ID and GPA properties
    - Add try/catch block to demonstrate exception for ID property
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region - constructors
            // use of master constructor
            Student billy = new Student("Billy", 464534, 3.5f);

            // use of constructor (name and id)
            Student lorraine = new Student("Lorraine", 320980);

            // use of default constructor
            Student bro = new Student();

            // print info of each student
            billy.printState();
            lorraine.printState();
            bro.printState();
            #endregion

            #region - use of name field and id, gpa properties
            // use of getter and setter for name field
            bro.Name = "Bro";
            Console.WriteLine("New name for student ID {0}: {1}", bro.ID, bro.Name);

            // use of getter and setter for id
            bro.ID = 300498;
            Console.WriteLine("New ID for student {0}: {1}", bro.Name, bro.ID);

            // use of getter and setter for gpa
            lorraine.GPA = 4.0f;
            Console.WriteLine("New GPA for student {0}: {1}", lorraine.Name, lorraine.GPA);

            Console.WriteLine();
            #endregion

            #region - exception throwing
            try
            {
                // set Billy's ID outside of range 100000-999999
                billy.ID = 404;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
