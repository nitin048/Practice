using System;

namespace Is_it_hot_or_cold
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
                    int x = Convert.ToInt32(Console.ReadLine()), x1 = 0;

                    for (int i = 0; i < x; ++i)
                    {
                        x1 = Convert.ToInt32(Console.ReadLine());
                        if (x1>20)
                        {
                            Console.WriteLine("HOT");
                        }
                        else
                        {
                            Console.WriteLine("COLD");
                        }
                   

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

