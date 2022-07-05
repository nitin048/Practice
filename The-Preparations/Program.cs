/*
 https://www.codechef.com/submit/SUPCHEF
 */
using System;

namespace The_Preparations
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
                    Console.WriteLine("Let's check chef's prepration");
                    Console.WriteLine("Enter your values in an array");
                    int[] x = new int[3];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }

                    if (x[0]>(x[1]*x[2]))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
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

