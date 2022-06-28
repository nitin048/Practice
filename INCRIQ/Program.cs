/*

Problem
A study has shown that playing a musical instrument helps in increasing one's IQ by 77 points. Chef knows he can't beat Einstein in physics, but he wants to try to beat him in an IQ competition.

You know that Einstein had an IQ of 170170, and Chef currently has an IQ of XX.

Determine if, after learning to play a musical instrument, Chef's IQ will become strictly greater than Einstein's.

Print "Yes" if it is possible for Chef to beat Einstein, else print "No" (without quotes).

You may print each character of the string in either uppercase or lowercase (for example, the strings yEs, yes, Yes, and YES will all be treated as identical).

Input Format
The first and only line of input will contain a single integer XX, the current IQ of Chef.
Output Format
For each testcase, output in a single line "Yes" or "No"
You may print each character of the string in either uppercase or lowercase (for example, the strings yEs, yes, Yes, and YES will all be treated as identical).


 */

using System;

namespace INCRIQ
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EinsteinIQ = 170;
            Console.WriteLine("lets test your chef's IQ after learning to play a musical instrument");
            Console.WriteLine("Enter the value");
            int x = int.Parse(Console.ReadLine());
            try
            {
                if ((x>=EinsteinIQ)&&(x<200))
                {
                    Console.WriteLine("Yes");
                }
                else if (x<=EinsteinIQ)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

