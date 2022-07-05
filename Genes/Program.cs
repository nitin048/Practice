/*
 https://www.codechef.com/submit/GENE01
 */
using System;

namespace Genes
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
                    Console.WriteLine("Lets check eye color of your child");
                    Console.WriteLine("Enter your color code {R,G,B} ex:RG or GB");
                    Console.WriteLine("--------------------------------------------");
                    string x = Console.ReadLine().ToUpper();
                    if (x == "RB")
                    {
                        Console.WriteLine("R");
                    }
                    else if (x == "BB")
                    {
                        Console.WriteLine("B");
                    }
                    else if (x=="GB")
                    {
                        Console.WriteLine("B");
                    }
                    else
                    {
                        Console.WriteLine("Combination does not match try again.");
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

