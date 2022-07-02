/*
 Problem
It is the World Cup Finals. Chef only finds a match interesting if the skill difference of the competing teams is less than or equal to D.

Given that the skills of the teams competing in the final are X and Y respectively, determine whether Chef will find the game interesting or not.

Input Format
The first line of input will contain a single integer T, denoting the number of testcases. The description of T testcases follows.
Each testcase consists of a single line of input containing three space-separated integers X, Y, and D — the skill levels of the teams and the maximum skill difference.
Output Format
For each testcase, output "YES" if Chef will find the game interesting, else output "NO" (without the quotes). The checker is case-insensitive, so "YeS" and "nO" etc. are also acceptable.

Sample 1:
Input
5 3 4
5 3 1
5 5 0


Output
YES
NO
YES
Explanation:
Test case 1: The skill difference between the teams is 2, which is less than the maximum allowed difference of 4.

Test case 2: The skill difference between the teams is 2, which is more than the maximum allowed difference of 1.


 */

using System;

namespace CupFinals
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
                    Console.WriteLine("Welcome to world cip finals🏆");
                    Console.WriteLine("Enter the Skills of Both the team :- Team A");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Skills of Both the team :- Team B");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Skills Diff of Both the team");
                    int d = int.Parse(Console.ReadLine());
                    if (Math.Abs(a-b)<=d)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
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

