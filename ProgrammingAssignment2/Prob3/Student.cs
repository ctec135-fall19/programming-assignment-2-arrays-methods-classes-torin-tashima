/*
Author: Torin Tashima
Date:   10/13/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 3

   Classes (Student class)

Things to add:
    - A Name field along with the getter and setter
    - An ID property (throw exception if ID is outside the range of
        100000 to 999999)
    - An automatic property for GPA
    - Three constructors: master, default, and one that sets only name and id
    - A PrintState() method to print the student's information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Student
    {
        // fields
        private string studentName;
        private int studentID;

        // properties
        public string Name
        {
            get { return studentName; }
            set
            {
                if (value.Length > 30) { studentName = value.Substring(0, 30); }
                else studentName = value;
            }
        }

        public int ID
        {
            get { return studentID; }
            set
            {
                if (value >= 100000 && value <= 999999) { studentID = value; }
                else throw new Exception("Student ID cannot be set; must be between 100000 and 999999.");
            }
        }

        // automatic properties
        public float GPA { get; set; }

        // constructors
        // master
        public Student(string name, int id, float gpa)
        {
            Name = name;
            ID = id;
            GPA = gpa;
        }

        // only name and id inputs
        public Student(string name, int id) : this(name, id, 0.0f) { }

        // default
        public Student() : this("No-Name", 123456, 0.0f) { }

        // methods
        public void printState()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("GPA: {0}", GPA);
            Console.WriteLine();
        }
    }
}
