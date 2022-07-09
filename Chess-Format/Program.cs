/*
 Chess-Format
 */
using System;

namespace Chess_Format
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
                    Console.WriteLine("Let's check Chess Format ");
                    Console.WriteLine("Enter your input");
                    int[] x = new int[2];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i]= int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("--------------------------------------------------------------");
                    if ((x[0]+x[1])<3)
                    {
                        Console.WriteLine("Bullet");
                    }
                    else if ((3 < (x[0] + x[1])) && ((x[0] + x[1]) <= 10))
                    {
                        Console.WriteLine("Blitz");
                    }
                    else if ((11 < (x[0] + x[1])) && ((x[0] + x[1]) <= 60))
                    {
                        Console.WriteLine("Rapid");
                    }
                    else if (60<(x[0]+x[1]))
                    {
                        Console.WriteLine("Classical");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    Console.WriteLine("--------------------------------------------------------------");
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

