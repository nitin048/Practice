/*
 Problem
Three numbers A, B and C are the inputs. Write a program to find second largest among them.

Input
The first line contains an integer T, the total number of testcases. Then T lines follow, each line contains three integers A, B and C.

Output
For each test case, display the second largest among A, B and C, in a new line.

Example
Input:3

120 11 400
10213 312 10
10 3 450


Output
120
312
10
 */
using System;

namespace Second_Largest
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
                    Console.WriteLine("Hi,Lets find the second largest no.");
                    Console.WriteLine("How many number you want to enter to check the second largest number ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now,enter all your values one by one");
                    int[] a = new int[x];
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(a);
                    Array.Reverse(a);
                    Console.WriteLine("Second Largest Value In Array is : " + a[1]);
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

