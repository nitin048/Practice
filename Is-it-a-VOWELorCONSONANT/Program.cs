/*
 https://www.codechef.com/submit/VOWELTB
 */
using System;

namespace Is_it_a_VOWELorCONSONANT
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
                    Console.WriteLine("Let's check Is_it_a_VOWEL or CONSONANT ");
                    Console.WriteLine("Enter a character (C) as input and check whether the given character is a vowel or a consonant.");
                    string x = Console.ReadLine().ToLower();
                    Console.WriteLine("-------------------------------------------------------------");
                    if ((x=="a")||x=="e"||(x=="i")||(x=="o")||(x=="u"))
                    {
                        Console.WriteLine("VOWEL");
                    }
                    else
                    {
                        Console.WriteLine("CONSONANT");
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

