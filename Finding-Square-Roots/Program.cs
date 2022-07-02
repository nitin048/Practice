/*

Problem

In olden days finding square roots seemed to be difficult but nowadays it can be easily done using in-built functions available across many languages .

Assume that you happen to hear the above words and you want to give a try in finding the square root of any given integer using in-built functions. So here's your chance.

Input
The first line of the input contains an integer T, the number of test cases. T lines follow. Each line contains an integer N whose square root needs to be computed.

Output
For each line of the input, output the square root of the input integer, rounded down to the nearest integer, in a new line.

Input:

10
5
10000

Output:
3
2
100

 */
using System;

namespace Finding_Square_Roots
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
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Hello,Let's find the Find the Sqrt🤓");
                    uint x = uint.Parse(Console.ReadLine());
                    double ans = Math.Sqrt(x);
                    Console.WriteLine("The sqrt of "+x+" is :"+" "+Math.Round(ans));
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Do you want to run the prgm again?🤔\nYes or No");
                    confrim = Console.ReadLine().ToLower();
                } while (confrim=="yes");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Thank you!!🤗");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!!!☠️");
                Console.WriteLine("\nHere is the exception:->"+" "+ex);
            }
            
        }
    }
}

