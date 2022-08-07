using System;

namespace Mileage_matters
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
                        double N = 0, X = 0, Y = 0, A = 0,B = 0,Petrol=0, Diesle = 0,P=0,D=0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        N = Convert.ToDouble(split[0]);
                        X = Convert.ToDouble(split[1]);
                        Y = Convert.ToDouble(split[2]);
                        A = Convert.ToDouble(split[3]);
                        B = Convert.ToDouble(split[4]);

                        P = N / A;
                        D = N / B;
                        Petrol = P * X;
                        Diesle = D * Y;
                        if (Petrol>Diesle)
                        {
                            Console.WriteLine("DIESLE");
                        }
                        else if(Petrol == Diesle)
                        {
                            Console.WriteLine("ANY");
                        }
                        else
                        {
                            Console.WriteLine("PETROL");
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

