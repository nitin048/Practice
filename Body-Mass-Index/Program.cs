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
                    int BMI = 0;
                    BMI = Convert.ToInt32(y / (result* result));
                    HashSet<double> nums = new HashSet<double> { 19, 20, 21, 22, 23, 24 };
                    HashSet<double> nums1 = new HashSet<double> { 25, 26, 27, 28, 29 };
                    Console.WriteLine("--------------------------------------------------------------");
                    if (BMI<=18)
                    {
                        Console.WriteLine("Underweight");
                    }
                    else if (nums.Contains(BMI))
                    {
                        
                                Console.WriteLine("Normal");
                         
                    }
                    else if (nums1.Contains(BMI))
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

