
/*
 https://www.codechef.com/submit/CREDITS?tab=statement
 */
using System;

namespace Complete_the_credits
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
                    Console.WriteLine("Let's check your credit");
                    Console.WriteLine("Enter your value range 1-100");
                    int x = int.Parse(Console.ReadLine());
                    if (x>65)
                    {
                        Console.WriteLine("Overload");
                    }
                    else if (x<35)
                    {
                        Console.WriteLine("Underload");
                    }
                    else
                    {
                        Console.WriteLine("Normal");
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

