/*
 https://www.codechef.com/submit/MIXTURE
 */
using System;

namespace Which_Mixture
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
                    Console.WriteLine("Let's check Which_Mixture it is ");
                    Console.WriteLine("Enter an input");
                    int[] x = new int[2];
                    for (int i = 0; i < x.Length; i++)
                    {
                        x[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("-------------------------------------------------------------");
                    if ((x[0]>0)&&(x[1]>0))
                    {
                        Console.WriteLine("Solution");
                    }
                    else if((x[1]==0)&&(x[0]>0))
                    {
                        Console.WriteLine("Solid");
                    }
                    else if ((x[0]==0)&&(x[1]>0))
                    {
                        Console.WriteLine("Liquid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
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

