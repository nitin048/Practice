/*
 https://www.codechef.com/submit/FLOW010
 */
using System;

namespace Id_and_Ship
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
                    Console.WriteLine("Let's check Id_and_Ship");
                    char x = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("--------------------------------------------------------------");
                    if (x=='b')
                    {
                        Console.WriteLine("BattleShip");
                    }
                    else if (x == 'c')
                    {
                        Console.WriteLine("Cruiser");
                    }
                    else if (x == 'd')
                    {
                        Console.WriteLine("Destroyer");
                    }
                    else if (x == 'f')
                    {
                        Console.WriteLine("Frigate");
                    }
                    else
                    {
                        Console.WriteLine("invalid input\nchoose within b,c,d,f");
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

