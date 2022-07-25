using System;
using System.Linq;

namespace Chef_On_Island
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
                    int x = Convert.ToInt32(Console.ReadLine()), x1 = 0, x2 = 0, y1 = 0, y2 = 0, D=0;
                    double a = 0, b = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(split[0]);
                        x2 = Convert.ToInt32(split[1]);
                        y1 = Convert.ToInt32(split[2]);
                        y2 = Convert.ToInt32(split[3]);
                        D = Convert.ToInt32(split[4]);

                        a = (x1 / y1);
                        b = (x2 / y2);
                        double[] v = { a, b };
                        Array.Sort(v);

                        if (v[0]>=D)
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

