/*
 Problem
Chef has N empty bottles where each bottle has a capacity of X litres.
There is a water tank in Chef-land having K litres of water. Chef wants to fill the empty bottles using the water in the tank.

Assuming that Chef does not spill any water while filling the bottles, find out the maximum number of bottles Chef can fill completely.

Input Format
First line will contain T, number of test cases. Then the test cases follow.
Each test case contains of a single line of input, three integers N, X and K.
Output Format
For each test case, output in a single line answer, the maximum number of bottles Chef can fill completely.

Input:3

5 2 8
10 5 4
3 1 4

Output
4
0
3
 */

using System;

namespace Chef_and_WaterBottles
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
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Welcome let's fill water bottle🍼");
                    Console.WriteLine("Enter the no of bottle to be filled");
                    uint n = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the capacity of bottle ");
                    uint x = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the capacity of water tank");
                    uint k = uint.Parse(Console.ReadLine());
                    uint s = k / x;
                    if (n>=s)
                    {
                        Console.WriteLine("The maximum number of bottles Chef can fill completely is : "+" "+s);
                    }
                    else if (n<s)
                    {
                        Console.WriteLine("The maximum number of bottles Chef can fill completely is : "+" "+n);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!!!");
                    }
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Do you want to play again!!!😀\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm=="yes");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Thank you🫡");
            }
            catch (Exception ex)
            {
                Console.WriteLine("invalid input");
                Console.WriteLine("Here is the exception:-> "+ex);
            }
           
        }
    }
}

