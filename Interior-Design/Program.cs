using System;

namespace Interior_Design
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
                    int x = Convert.ToInt32(Console.ReadLine()), x1 = 0, x2 = 0, y1 = 0, y2 = 0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(split[0]);
                        x2 = Convert.ToInt32(split[1]);
                        y1 = Convert.ToInt32(split[2]);
                        y2 = Convert.ToInt32(split[3]);
                       
                        if ((x1+x2)<(y1+y2))
                        {
                            Console.WriteLine(x1+x2);
                        }
                        else
                        {
                            Console.WriteLine(y1+y2);
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

