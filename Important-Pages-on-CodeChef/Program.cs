/*
 Problem
Chef noticed that some users are not aware of the practice page on CodeChef, and some others are not aware of the rated contests on CodeChef.
So, chef wants to send an email to the users depending on which of the following groups they fall into:

If the user has never submitted on the practice page then send an email with the text:

https://www.codechef.com/practice

If the user has submitted on the practice page, but never participated in a contest then send an email with the text:

https://www.codechef.com/contests

If the user has submitted on the practice page as well as participated in a contest then send an email with the text:

https://discuss.codechef.com

so that they may discuss with other members of the community.

Help chef by writing a program that takes as input two integers A and B where:

A = 1 if the user has submitted on the practice page and 0 otherwise.
B =1 if the user has participated in a contest and 0 otherwise.
Output the appropriate link to be displayed in the email.

Input Format
The input consists of a single line with two space-separated integers A and B.
Output Format
Print one of the following strings as per the problem statement.
https://www.codechef.com/practice
https://www.codechef.com/contests
https://discuss.codechef.com

Sample 1:
Input
0 1
Output
https://www.codechef.com/practice
Explanation:
The user has not submitted on the practice page, so the program must output the link to the practice page.

Sample 2:
Input
1 0
Output
https://www.codechef.com/contests
Explanation:
The user has submitted on the practice page, but has not participated in a contest, so the program must output the link to the contest page.
 */
using System;

namespace Important_Pages_on_CodeChef
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
                    Console.WriteLine("Welcome to codechef");
                    Console.WriteLine("Enter 2 values both should be either 0 & 1");
                    int[] x = new int[2];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }
                    int a = x[0];
                    int b = x[1];
                    if ((a==0)&&(b==1))
                    {
                        Console.WriteLine("https://www.codechef.com/practice\nVist this website");
                    }
                    else if((a == 1) && (b == 0))
                    {
                        Console.WriteLine("https://www.codechef.com/contests\nVist this website");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input either 0 or 1");
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

