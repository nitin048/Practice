/*
 Problem
The National Championships are starting soon. There are 4 race categories, numbered from 1 to 4, that Chef is interested in.
Chef is participating in exactly 2 of these categories.

Chef has an arch-rival who is, unfortunately, the only person participating who is better than Chef,
i.e, Chef can't defeat the arch-rival in any of the four race categories but can defeat anyone else. Chef's arch-rival is also participating in exactly 2 of the four categories.

Chef hopes to not fall into the same categories as that of the arch-rival.

Given X, Y, A, B where X, Y are the races that Chef participates in, and A, B are the races that Chef's arch-rival participates in,
find the maximum number of gold medals (first place) that Chef can win.

Input Format
The first line of input contains an integer T, denoting the number of testcases. The description of T testcases follows.
Each testcase consists of a single line containing four space-separated integers — the values of X, Y, A and B respectively.

Output Format
For each testcase, print a single line containing one integer — the maximum number of gold medals that Chef can win.

Sample 1:
Input:3


4 3 1 2
4 2 1 2
2 1 1 2

Output
2
1
0

note: need improvement ,still failing in may test cases 
 */
using System;

namespace Chef_and_Races
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
                    Console.WriteLine("Welcom to the Race 🏎");
                    Console.WriteLine("Please enter 2 values for chef race ranging from 1-4");
                    int[] q = new int[2];
                    int ans = 0;
                    int nothing = 0;
                    for (int i = 0; i < q.Length; i++)
                    {
                        q[i] = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Now enter 2 values for arch-rival race ranging from 1-4");
                    int[] x = new int[2];
                    for (int j = 0; j < x.Length; j++)
                    {
                        x[j] = int.Parse(Console.ReadLine());
                    }
                    if ((q[0]!=q[1])&&(x[0]!=x[1]))
                    {
                        if ((q[0] != x[0]) && (q[0] != x[1]))
                        {
                            ans++;
                        }
                        else
                        {
                            nothing++;
                        }
                    }
                   
                    if ((q[0] != q[1]) && (x[0] != x[1]))
                    {
                        if ((q[1] != x[0]) && (q[1] != x[1]))
                        {
                            ans++;
                        }
                        else
                        {
                            nothing++;
                        }
                    }
                    
                    
                   
                    Console.WriteLine("the maximum number of gold medals that Chef can win is:"+" "+ans);
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

