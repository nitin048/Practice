/*
 Problem
Janmansh and Jay are playing a game. They start with a number X and they play a total of Y moves.
Janmansh plays the first move of the game, after which both the players make moves alternatingly.

In one move, a player can increment or decrement X by 1.

If the final number after performing Y moves is even, then Janmansh wins otherwise, Jay wins. Determine the winner of the game if both the players play optimally.

Input Format
The first line will contain T - the number of test cases. Then the test cases follow.
The first and only line of each test case contains two integers X, Y - the starting number and the total number of moves respectively.
Output Format
For each test case, output the winning player (Janmansh or Jay).

You may print each character of Janmansh and Jay in uppercase or lowercase (for example, JAY, jaY, JAy will be considered identical).

Sample 1:
Input

2 2
4 3

Output
Janmansh
Jay


 */
using System;

namespace Janmansh_and_Games
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
                    Console.WriteLine("Welcome to the Game");
                    Console.WriteLine("Enter the starting value of game");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the total no's moves");
                    int y = int.Parse(Console.ReadLine());
                    for (int i = 0; i < y; i++)
                    {
                        x++;
                    }
                    if (x%2==0)
                    {
                        Console.WriteLine("Janmash win!!!");
                    }
                    else
                    {
                        Console.WriteLine("Jay win!!!");
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

