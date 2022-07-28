using System;

namespace Passes_for_Fair
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
                    int x = Convert.ToInt32(Console.ReadLine()), N = 0, K = 0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        N = Convert.ToInt32(split[0]);
                        K = Convert.ToInt32(split[1]);
                      

                        if (N<K)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
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

