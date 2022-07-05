using System;

namespace Gross_Salary
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
                    Console.WriteLine("Let's check your Gross salary");
                    Console.WriteLine("Enter your Basic Salary");
                    double BasicSalary = double.Parse(Console.ReadLine());
                    double HRA = 0;
                    double DA = 0;
                    
                    if ( BasicSalary<1500)
                    {
                        HRA = BasicSalary / 100*10;
        
                        DA = BasicSalary / 100 * 90;
                        Console.WriteLine("Gross Salary is :"+" "+(BasicSalary+HRA+DA));
                    }
                    else if (BasicSalary >= 1500)
                    {
                        HRA = 500;
                        DA = (BasicSalary / 100) * 98;
                        Console.WriteLine("Gross Salary is :" + " " + (BasicSalary + HRA + DA));
                        
                    }
                    
                    Console.WriteLine("--------------------------------------------");
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

