/*
 Problem
Write a program to take two numbers as input and print their difference if the first number is greater than the second number otherwiseotherwise print their sum.

Input:
First line will contain the first number (N1N1)
Second line will contain the second number (N2N2)
Output:
Output a single line containing the difference of 2 numbers (N1 - N2)(N1−N2) if the first number is greater than the second number otherwise output their sum (N1 + N2)(N1+N2).

Sample Input:
82
28

28
82
Sample Output:
54

110
 */
using System;

namespace Sum_OR_Difference
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
                    Console.WriteLine("Let's check Sum or Difference");
                    Console.WriteLine("Enter any 2 no's");
                    int[] x = new int[2];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }
                    if (x[0]>x[1])
                    {
                        Console.WriteLine("1st no is greater so will find difference of them");
                        Console.WriteLine("The difference is: "+" "+Math.Abs(x[0]-x[1]));
                    }
                    else
                    {
                        Console.WriteLine("2nd is greater so will perform sum of both");
                        Console.WriteLine("The sum is :"+" "+(x[0]+x[1]));

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

