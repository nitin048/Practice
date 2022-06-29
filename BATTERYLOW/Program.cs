/*
 Problem
Chef's phone shows a Battery Low notification if the battery level is 15% or less.

Given that the battery level of Chef's phone is X%, determine whether it would show a Battery low notification.

Input Format
First line will contain T, number of test cases. Then the test cases follow.
Each test case contains a single line of input, an integer XX, denoting the battery level of the phone.
Output Format
For each test case, output in a single line \texttt{Yes}Yes, if the battery level is 15% or below. Otherwise, print \text{No}No.

You may print each character of \texttt{Yes}Yes and \text{No}No in uppercase or lowercase (for example, \texttt{YeS}YeS, \texttt{YES}YES, \texttt{yes}yes will be considered identical).

Subtask #1 (100 points): original constraints

Sample 1:
Input


15
3
65

Output
Yes
Yes
No
 */
using System;

namespace BATTERYLOW
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            do
            {
                Console.WriteLine("let's check chef's phone bettery level\nEnter the value :");
                int x = int.Parse(Console.ReadLine());
                if ((x > 15)&&(x<=100))
                {
                    Console.WriteLine("need not to charge : No ");
                }
                else if ((x <= 15)&&(x>0))
                {
                    Console.WriteLine("Bettery low, Plug into the charger : Yes");
                }
                else
                {
                    Console.WriteLine("Input should range 1 - 100\nRetry");
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("do you want to check again\nYes or No");
                c = Console.ReadLine().ToLower();
            } while (c=="yes");
            Console.WriteLine("Thank you!");
        }
    }
}

