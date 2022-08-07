using System;

namespace How_many_unattempted_problems
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
                    System.Console.WriteLine("Enter your data");
                    
                    double X = 0, Y = 0;

                    for (int i = 0; i < 1; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        X = Convert.ToDouble(str[0]);
                        Y = Convert.ToDouble(str[1]);

                        Console.WriteLine(Math.Abs(X-Y));
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

