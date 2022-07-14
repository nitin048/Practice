using System;
using System.Collections.Generic;

namespace Body_Mass_Index
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
                    Console.WriteLine("Let's check your Body_Mass_Index ");
                    Console.WriteLine("Enter your height in feet");
                    double x = double.Parse(Console.ReadLine());
                    double result=meter(x);
                    Console.WriteLine("Enter your weight in kg");
                    int y = int.Parse(Console.ReadLine());
                    double BMI = 0;
                    BMI = y / (result* result);
                    
                    Console.WriteLine("--------------------------------------------------------------");
                    if (BMI<=18)
                    {
                        Console.WriteLine("Underweight");
                    }
                    else if (BMI>=19 && BMI<=24)
                    {
                        
                                Console.WriteLine("Normal");
                         
                    }
                    else if (BMI >= 25 && BMI <= 29)
                    {
                      
                                Console.WriteLine("overweight");
                         
                    }
                    else
                    {
                        Console.WriteLine("Obesity");
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

        public static double meter(double x)
        {
             const double feet = 0.3048;

            double m = x * feet;

            return m;
        }
    }
}

