/*
 https://www.codechef.com/submit/CHEFTRANS
 */
using System;

namespace Chef_and_Vacation_Transportation
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
                    Console.WriteLine("Enter the time take by flight ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the time take by bus ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the time take by train ");
                    int z = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------");
                    int result = x + y;
                    if (result>z )
                    {
                        Console.WriteLine("TRAIN");
                    }
                    else if (result<z)
                    {
                        Console.WriteLine("PLANEBUS");

                    }
                    else
                    {
                        Console.WriteLine("Equals");
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

