using System;

namespace Burgers
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
                    int x = Convert.ToInt32(Console.ReadLine());
                    double X = 0,Y=0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ') ;
                        X = Convert.ToDouble(str[0]);
                        Y = Convert.ToDouble(str[1]);

                        if (X<Y)
                        {
                            Console.WriteLine(X);
                        }
                        else
                        {
                            Console.WriteLine(Y);
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

