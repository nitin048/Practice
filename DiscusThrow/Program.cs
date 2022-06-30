/*
Problem
In discus throw, a player is given 3 throws and the throw with the longest distance is regarded as their final score.

You are given the distances for all 3 throws of a player. Determine the final score of the player.

Input Format
First line will contain T, number of test cases. Then the test cases follow.
Each test case contains of a single line of input, three integers A, B, and C denoting the distances in each throw.
Output Format
For each test case, output the final score of the player.

Sample 1:
Input:3


10 15 8
32 32 32
82 45 54

Output
15
32
82
Explanation:
Test Case 1: The longest distance is achieved in the second throw, which is equal to 15 units. Thus, the answer is 15.

Test Case 2: In all throws, the distance is 32 units. Thus, the final score is 32.

Test Case 3: The longest distance is achieved in the first throw which is equal to 82 units. Thus, the answer is 82.
 */

using System;

namespace DiscusThrow
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
                    Console.WriteLine("Welome to Discus Throw");
                    Console.WriteLine("Enter your 3 values to chech the final score");
                    int count = 3;
                    int highest=0;
                    int index;
                    int x = 0;
                    int[] arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        arr[i]= int.Parse(Console.ReadLine());
                        
                     }
                    
                    foreach (dynamic i in arr)
                    {
                        if (i > highest)
                        { highest = i;
                            index = x;
                        }
                        x++;
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Longest distance disc thrown is :"+" "+highest+" "+"meter");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Do you want to play again?\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm=="yes");
                Console.WriteLine("Thank you!👋");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Here is the exception:->"+" "+ex);
            }
            
            
        }
    }
}

