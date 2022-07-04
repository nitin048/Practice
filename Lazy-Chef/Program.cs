using System;

namespace Lazy_Chef
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
                    Console.WriteLine("Welcome Lazy chef ");
                    Console.WriteLine("Enter the values");
                    int size = 0;
                    size = int.Parse(Console.ReadLine());
                    int[] a = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    int ans = a[0] * a[1];
                    int ans2 = a[0] + a[2];
                    Console.WriteLine( "--------------------");
                    
                    if (ans<ans2)
                    {
                        Console.WriteLine(ans);
                    }
                    else
                    {
                        Console.WriteLine(ans2);
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

