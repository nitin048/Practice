/* Problem
Ezio can manipulate at most X number of guards in the apple garden.

Given that there are Y number of guards, predict if he can safely manipulate all of them.

Input Format
First line will contain T, number of test cases. Then the test cases follow.
Each test case contains of a single line of input, two integers X and Y.
Output Format
For each test case, print \text {YES}YES if it is possible for Ezio to manipulate all the guards.Otherwise, print \texttt{ NO}
NO.

You may print each character of the string in uppercase or lowercase (for example, the strings \texttt{YeS}YeS, \texttt
{ yEs}
yEs, \texttt
{ yes}
yes and \texttt{YES}YES will all be treated as identical).

Constraints

1001≤T≤100
1≤X,Y≤100


 Input


5 7
6 6
9 1

Output
NO
YES
YES
 */


using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            int y = int.Parse(Console.ReadLine());

            if (x>=y)
            {
                Console.WriteLine("Yes");
            }
            else if (x<=y)
            {
                Console.WriteLine("No");
            }
            else if(x==y)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}

