/*
 Problem
The purpose of this problem is to verify whether the method you are using to read input data is sufficiently fast to handle problems branded with the enormous Input/Output warning. You are expected to be able to process at least 2.5MB of input data per second at runtime.

Input
The input begins with two positive integers n k (n, k<=107). The next n lines of input contain one positive integer ti, not greater than 109, each.

Output
Write a single integer to output, denoting how many integers ti are divisible by k.

Sample 1:

Input

7 3 -- input x,y

1
51
966369
7
9
999996
11

Output
4

Explanation:
The integers divisible by 33 are 51, 966369, 9,51,966369,9, and 999996999996. Thus, there are 44 integers in total.


 */


using System;

namespace INTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var ans = 0;
            for (int i = 0; i < x; i++)
            {


              int t = int.Parse(Console.ReadLine());
                if (t%y==0)
                {
                    ans++;
                }
            }

            Console.WriteLine("your output is:"+ans);
        }
    }
}

