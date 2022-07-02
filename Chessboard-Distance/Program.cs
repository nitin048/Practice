/*
 Problem
https://www.codechef.com/submit/CHESSDIST
 */
using System;

namespace Chessboard_Distance
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
                    Console.WriteLine("Let's find chessboard distance♖♘♟");
                    Console.WriteLine("Enter the values of X");
                    int[]x = new int[2];
                    int[] y = new int[2];
                    for (int i = 0; i < 2; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    } 
                    Console.WriteLine("Enter the value of Y");
                    for (int j = 0; j < 2; j++)
                    {
                        y[j] = int.Parse(Console.ReadLine());
                    }
                    int x1 = x[0];
                    int x2 = x[1];
                    int y1 = y[0];
                    int y2 = y[1];

                     int s =Math.Abs(x1 - y1);
                    int p = Math.Abs(y2 - x2);

                    if (s>=p)
                    {
                        Console.WriteLine("chessboard distance :" +" "+s);
                    }
                    else
                    {
                        Console.WriteLine("chessboard distance :" + " " + p);
                    }

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Do you want to run the prgm again?🤔\nYes or No");
                    confrim = Console.ReadLine().ToLower();
                } while (confrim=="yes");
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

