using System;

namespace MY1STCONTEST
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
                    double x1 = 0, x2 = 0, x3 = 0, a = 0, b = 0,;

                    for (int i = 0; i < 1; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(split[0]);
                        x2 = Convert.ToInt32(split[1]);
                        x3 = Convert.ToInt32(split[2]);
                        a = Math.Abs(x1-x2);
                        b = Math.Abs(a-x3);

                        Console.WriteLine(a +" "+b);
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

