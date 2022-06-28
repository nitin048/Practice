/*
 Problem
There is a group of NN friends who wish to enroll in a course together. The course has a maximum capacity of MM students that can register for it. If there are KK other students who have already enrolled in the course, determine if it will still be possible for all the NN friends to do so or not.

Input Format
The first line contains a single integer TT - the number of test cases. Then the test cases follow.
Each test case consists of a single line containing three integers NN, MM and KK - the size of the friend group, the capacity of the course and the number of students already registered for the course.
Output Format
For each test case, output Yes if it will be possible for all the NN friends to register for the course. Otherwise output No.

You may print each character of Yes and No in uppercase or lowercase (for example, yes, yEs, YES will be considered identical).
 */
using System;

namespace CourseReg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum capacity of students");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Students alredy enrolled");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of student who want to enroll");
            int x = int.Parse(Console.ReadLine());

            try
            {
                if ((x < m) && (y < m) && (x < y))
                {
                    if ((x <= (Math.Abs(m - y))))
                    {
                        Console.WriteLine("students are enrolled: YES");

                    }
                    else
                    {
                        Console.WriteLine("Sorry batch is running with its full capacity : NO");
                    }
                }
                else
                {
                    Console.WriteLine("somthing went wrong!");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Remaining seats  avialable is :" + " " + (Math.Abs(x - (m - y))));
        }
    }
}
