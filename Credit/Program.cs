/* 
 Problem
To access CRED programs, one needs to have a credit score of 750 or more.
Given that the present credit score is X, determine if one can access CRED programs or not.

If it is possible to access CRED programs, output \texttt{YES}YES, otherwise output \texttt{NO}NO.

Input Format
The first and only line of input contains a single integer X, the credit score.

Output Format
Print \texttt{YES}YES if it is possible to access CRED programs. Otherwise, print \texttt{NO}NO.

You may print each character of the string in uppercase or lowercase (for example, the strings \texttt{YeS}YeS, \texttt{yEs}yEs, \texttt{yes}yes and \texttt{YES}YES will all be treated as identical).

Constraints
0≤X≤100

Subtasks
Subtask 1 (100 points): Original constraints.

Sample 1:
Input
823

Output
YES

Explanation:
Since 823 ≥ 750, it is possible to access CRED programs.


Sample 2:

Input
251

Output
NO

Explanation:
Since 251 <= 750, it is not possible to access CRED programs.
 */


using System;

namespace Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cred Program");
            Console.WriteLine("Check your credit score for the eligiblity \nie,min=600 max=750");
            Console.WriteLine("Enter your credit score ");
            int x = int.Parse(Console.ReadLine());

            try
            {
                if (x >= 750)
                {
                    Console.WriteLine("Yes");
                }
                else if (x <= 750)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
    }
}

