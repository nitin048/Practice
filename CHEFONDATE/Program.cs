using System;

namespace CHEFONDATE
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
                    int x = Convert.ToInt32(Console.ReadLine()), x1 = 0, x2 = 0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(split[0]);
                        x2 = Convert.ToInt32(split[1]);
                       
                        if (x1 >= x2 )
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
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

