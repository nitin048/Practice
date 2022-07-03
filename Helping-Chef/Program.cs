/*
 Problem
Write a program, which takes an integer N and if the number is less than 10 then display "Thanks for helping Chef!" otherwise print "-1".

Input
The first line contains an integer T, total number of testcases. Then follow T lines, each line contains an integer N.

Output
For each test case, output the given string or -1 depending on conditions, in a new line.

Input:3
 
1
12
-5

Output
Thanks for helping Chef!
-1
Thanks for helping Chef!
 */
using System;

namespace Helping_Chef
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
                    Console.WriteLine("Lets help chef");
                    Console.WriteLine("Enter number");
                    int x = int.Parse(Console.ReadLine());
                    if (x<10)
                    {
                        Console.WriteLine("Thank you chef!");
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
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

