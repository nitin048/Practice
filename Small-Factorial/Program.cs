/*
 Problem
Write a program to find the factorial value of any number entered by the user.

Input
The first line contains an integer T, the total number of testcases. Then T lines follow, each line contains an integer N.

Output
For each test case, display the factorial of the given number N in a new line.

Example
Input:3

3 
4
5


Output
6
24
120

 */
using System;

namespace Small_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string confrim;
                do
                {
                    Console.WriteLine("Let's find the factorial of a given number");
                    Console.WriteLine("Enter a number to find factorial");
                     int count = int.Parse(Console.ReadLine());
                    int[] x = new int[count+1];
                    int ans = 1;
                    for (int i = 1; i <= count; i++)
                    {
                        x[i]=i;

                        ans = ans * x[i];
                    }
                    Console.WriteLine( "----------------------");
                    Console.WriteLine("factorial of "+count+" is"+" "+ans);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Do you want to run the prgm again?🤔\nYes or No");
                    confrim = Console.ReadLine().ToLower();
                } while (confrim == "yes");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Thank you!!👋");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!!!☠️");
                Console.WriteLine("\nHere is the exception:->" + " " + ex);
            }
        }
    }
}

