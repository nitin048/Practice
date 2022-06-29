/*
 Problem
Chef has finally got the chance of his lifetime to drive in the F1 tournament. But, there is one problem. Chef did not know about the 107% rule and now he is worried whether he will be allowed to race in the main event or not.

Given the fastest finish time as X seconds and Chef's finish time as Y seconds, determine whether Chef will be allowed to race in the main event or not.

Note that, Chef will only be allowed to race if his finish time is within 107% of the fastest finish time.

107% rule

The 107% rule is a sporting regulation affecting Formula One racing qualifying sessions. During the first phase of qualifying, if the circuit is dry,
any driver who is eliminated in the first qualifying session and fails to set a lap within 107 percent of the fastest time in that session will not be allowed to start the race without permission from the race stewards.
For example, if the fastest Q1 lap time was 100 seconds, each driver who is eliminated in the session must complete at least one lap within 107 seconds to guarantee a race start.
The 107% rule was introduced for the 1996 season and remained in force until 2002. It was reintroduced for the 2011 season with minor modifications due to the knock-out qualifying format.


Input Format
First line will contain T, number of testcases. Then the testcases follow.
Each testcase contains of a single line of input, two space separated integers X and Y denoting the fastest finish time and Chef's finish time respectively.
Output Format
For each test case, output \text{YES}YES if Chef will be allowed to race in the main event, else output \texttt{NO}NO.

You may print each character of the string in uppercase or lowercase (for example, the strings \texttt{YeS}YeS, \texttt{yEs}yEs, \texttt{yes}yes and \texttt{YES}YES will all be treated as identical).

Sample 1:
Input

1 2
15 16
15 17
100 107

Output
NO
YES
NO
YES

Explanation:
Test case 11: The fastest car finished in 11 second. Thus, Chef should have finished on or before 1.071.07 seconds to ensure qualification but he finished in 22 seconds. Hence, Chef will not be allowed to race in the main event.

Test case 22: The fastest car finished in 15 seconds. Thus, Chef should have finished on or before 16.0516.05 seconds to ensure qualification and he managed to finish in 1616 seconds. Hence, Chef will be allowed to race in the main event.

Test case 33: The fastest car finished in 15 seconds. Thus, Chef should have finished on or before 16.0516.05 seconds to ensure qualification but he finished in 1717 seconds. Hence, Chef will not be allowed to race in the main event.

Test case 44: The fastest car finished in 100 seconds. Thus, Chef should have finished on or before 107107 seconds to ensure qualification and he finished just in time for qualification. Hence, Chef will be allowed to race in the main event.

 */
using System;

namespace F1RULE
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fi = 1.07;
            Console.WriteLine("Welcome plz enter your values");
            Console.WriteLine("fastest finish time as X seconds:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Chef's finish time as Y seconds");
            int y = int.Parse(Console.ReadLine());

            if (y<=(x*fi))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }




        }
    }
}

