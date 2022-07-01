/*

Problem
Chef has N friends. Chef promised that he would gift a pair of shoes (consisting of one left shoe and one right shoe) to each of his N friends.
Chef was about to go to the marketplace to buy shoes, but he suddenly remembers that he already had M left shoes.

What is the minimum number of extra shoes that Chef will have to buy to ensure that he is able to gift a pair of shoes to each of his N friends?

For example, if N = 2, M = 4, then Chef already has 4 left shoes, so he must buy 2 extra right shoes to form 2 pairs of shoes.

Therefore Chef must buy at least 2 extra shoes to ensure that he is able to get N = 2 pairs of shoes.

Input Format
The first line contains a single integer T - the number of test cases. Then the test cases follow.
The first line of each test case contains two integers N and M - the number of Chef's friends and the number of left shoes Chef has.
Output Format
For each test case, output the minimum number of extra shoes that Chef will have to buy to ensure that he is able to get N pairs of shoes.


Sample 1:
Input:3


2 4
6 0
4 3
Output
2
12
5
Explanation:
Test Case 1: Discussed in the problem statement

Test Case 2: Chef initially has no left shoes. He must buy 6 more left shoes and 6 more right shoes to form 6 pairs of shoes.

Test Case 3: Chef initially has 3 left shoes. He must buy 1 more left shoe and 4 more right shoes to form 4 pairs of shoes.

 */
using System;

namespace FINDSHOES
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
                    Console.WriteLine("welcome chef let's get shoes for your friends");
                    Console.WriteLine("Enter no of friends");
                    uint x = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Enter no of left shoes");
                    uint y = uint.Parse(Console.ReadLine());

                    if (x >= y)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("You need " + Math.Abs(x + (x - y)) + " extra right shoes");
                    }
                    else if (x < y)
                    {
                        Console.WriteLine("------------------------------------------");
                        uint ny = ((x + y) - y);
                        Console.WriteLine("You need " + Math.Abs(x + (x - ny)) + " extra right shoes");
                    }
                    else
                    {
                        Console.WriteLine("invalid input!!!");
                    }
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Do you want to play restart!\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm == "yes");
                Console.WriteLine("Thank you👋");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No of friends should be >= 1");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Here is the exception:-> "+ex);
            }
            
        }
    }
}

