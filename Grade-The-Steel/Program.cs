/*
 https://www.codechef.com/submit/FLOW014
 */
using System;

namespace Grade_The_Steel
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
                    Console.WriteLine("Let's check Grade of the Steel");
                    Console.WriteLine("Enter the value for test ex:Hardness(1-100),Carbon(0-1),Tensile strenght(1-100000)");
                    double[] x = new double[3];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("--------------------------------------------------------");
                    if ((x[0]>50)&&(x[1]<0.7)&&(x[2]>5600))
                    {
                        Console.WriteLine("10");
                    }
                    else if (((x[0] > 50) && (x[1] < 0.7)) || (x[2] > 5600))
                    {
                        Console.WriteLine("9");
                    }
                    else if ((x[0] > 50) || ((x[1] < 0.7) && (x[2] > 5600)))
                    {
                        Console.WriteLine("8");
                    }
                    else if (((x[0] > 50) && (x[2] > 5600)) || (x[1] < 0.7))
                    {
                        Console.WriteLine("7");
                    }
                    else if ((x[0] > 50) || ((x[1] < 0.7) || (x[2] > 5600)))
                    {
                        Console.WriteLine("6");
                    }
                    else if ((x[0] < 50) && ((x[1] > 0.7) && (x[2] < 5600)))
                    {
                        Console.WriteLine("5");
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

