/*
Problem
Chef is watching a football match. The current score is A:B, that is, team 1 has scored A goals and team 2 has scored B goals.
Chef wonders if it is possible for the score to become C:D at a later point in the game (i.e. team 1 has scored C goals and team 2 has scored D goals).
Can you help Chef by answering his question?

Input Format
The first line contains a single integer T - the number of test cases. Then the test cases follow.
The first line of each test case contains two integers A and B - the intial number of goals team 1 and team 2 have scored respectively.
The second line of each test case contains two integers C and D - the final number of goals team 1 and team 2 must be able to score respectively.
Output Format
For each testcase, output POSSIBLE if it is possible for the score to become C:DC:D at a later point in the game, IMPOSSIBLE otherwise.

You may print each character of POSSIBLE and IMPOSSIBLE in uppercase or lowercase (for example, possible, pOSsiBLe, Possible will be considered identical).


Sample 1:
Input:3


1 5
3 5

3 4
2 6

2 2
2 2


Output:

POSSIBLE
IMPOSSIBLE
POSSIBLE

 
 */

using System;

namespace TRUESCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string confirm;
                do
                {
                    Console.WriteLine("Wlecome to the football match!!!");
                    Console.WriteLine("Intial score of Team A");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Intial score of Team B");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now let's enter the final values for both the Teams");
                    Console.WriteLine("Final score Team A");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Final score Team B");
                    int d = int.Parse(Console.ReadLine());

                    if ((a <= c) && (b <= d))
                    {
                        Console.WriteLine("POSSIBLE");
                    }
                    else
                    {
                        Console.WriteLine("IMPOSSIBLE");
                    }
                    Console.WriteLine("Do you want to run the prgm again?\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm == "yes");

                Console.WriteLine("Thank you!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Here is the exception :->"+" "+ex.StackTrace);
            }
           
            
        }
    }
}

