/*
 https://www.codechef.com/submit/GOODWEAT
 */

using System;

namespace Good_Weather
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
                    Console.WriteLine("Lets check Weather of chef land");
                    Console.WriteLine("Enter your values in  ex:0 & 1");
                    int[] x = new int[7];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }
                    int sunnyday = 0;
                    int rainyday = 0;
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] == 1)
                        {
                            sunnyday++;
                        }
                        else
                        {
                            rainyday++;
                        }
                    }
                    Console.WriteLine("----------------------------------------------------------");
                    if (sunnyday>rainyday)
                    {
                        Console.WriteLine("It's Sunny day in chef land : Good Weather (Yes) ");
                    }
                    else
                    {
                        Console.WriteLine("It's Rainy day in chef land : Bad Weather (No) ");
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

