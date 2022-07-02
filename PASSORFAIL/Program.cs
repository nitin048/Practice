/*
 Problem
Chef is struggling to pass a certain college course.

The test has a total of N question, each question carries 3 marks for a correct answer and -1 for an incorrect answer.
Chef is a risk-averse person so he decided to attempt all the questions.
It is known that Chef got X questions correct and the rest of them incorrect. For Chef to pass the course he must score at least P marks.

Will Chef be able to pass the exam or not?

Input Format
First line will contain T, number of testcases. Then the testcases follow.
Each testcase contains of a single line of input, three integers N, X, P.
Output Format
For each test case output "PASS" if Chef passes the exam and "FAIL" if Chef fails the exam.

You may print each character of the string in uppercase or lowercase (for example, the strings "pAas", "pass", "Pass" and "PASS" will all be treated as identical).

Sample 1:
Input : 3

5 2 3
5 2 4
4 0 0

Output

PASS
FAIL
FAIL

 */

using System;

namespace PASSORFAIL
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
                    Console.WriteLine("Hi,Chef lets check you are pass🤩 or fail🥶");
                    Console.WriteLine("Total no's of question");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Total no's of question chef attemped correctlly");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Least passing you need is ");
                    int p = int.Parse(Console.ReadLine());
                    int ans = Math.Abs(n - x);
                    if ((ans>=p)&&(p!= 0))
                    {
                        Console.WriteLine("congratulations chef you Pass🥳");
                    }
                    else
                    {
                        Console.WriteLine("chef you fail😔");
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

