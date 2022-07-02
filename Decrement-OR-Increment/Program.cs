/*
Problem
Write a program to obtain a number N and increment its value by 1 if the number is divisible by 4 otherwiseotherwise decrement its value by 1.

Input:
First line will contain a number N.
Output:
Output a single line, the new value of the number.

Sample Input:
5

Sample Output:
4
EXPLANATION:
Since 5 is not divisible by 4 hence, its value is decreased by 1.


 */
using System;

namespace Decrement_OR_Increment
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
                    Console.WriteLine("Hi,Let's if no will increment or decremnet");
                    Console.WriteLine("Enter your value interger");
                    int x = int.Parse(Console.ReadLine());
                    if (x%4==0)
                    {
                        x++;
                    }
                    else
                    {
                        x--;
                    }
                    Console.WriteLine("The new value will:-> "+ x);
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

