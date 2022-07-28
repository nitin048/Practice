using System;

namespace Olympics_Ranking
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
                    int x = Convert.ToInt32(Console.ReadLine()), g1 = 0, s1 = 0, b1 = 0, g2 = 0, s2 = 0,b2=0;
                    
                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        g1 = Convert.ToInt32(split[0]);
                        s1 = Convert.ToInt32(split[1]);
                        b1 = Convert.ToInt32(split[2]);
                        g2 = Convert.ToInt32(split[3]);
                        s2 = Convert.ToInt32(split[4]);
                        b2 = Convert.ToInt32(split[4]);

                        if ((g1+s1+b1)>(g2+s2+b2))
                        {
                            Console.WriteLine("1");
                        }
                        else
                        {
                            Console.WriteLine("2");
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

