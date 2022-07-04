/*
 https://www.codechef.com/submit/HARDBET
 */
using System;

namespace Hardest_Problem_Bet
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
                    Console.WriteLine("Lets play Heardest problem bet!!!");
                    Console.WriteLine("Please enter the values for A ,B & C");
                    int[] x = new int[3];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("---------------------------------------");
                        if ((x[0]<x[1])&&(x[0]<x[2]))
                        {
                            Console.WriteLine("Draw");
                        }
                        else if((x[1] < x[0]) && (x[1] < x[2]))
                        {
                            Console.WriteLine("Bob");
                        }
                        else if ((x[2] < x[0]) && (x[2] < x[1]))
                        {
                            Console.WriteLine("Alice");
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

