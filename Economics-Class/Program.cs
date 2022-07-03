/*
 https://www.codechef.com/submit/ECOCLASS

Input:2

4
1 2 3 4
2 1 3 4

4
1 1 2 2
1 2 1 1

Output
2
1
 */
using System;

namespace Economics_Class
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
                    Console.WriteLine("Lets Help alice to understand makert in equilibrium");
                    Console.WriteLine("Enter the size of an array");
                    int x = int.Parse(Console.ReadLine());
                    int ans = 0;
                    int mm = 0;
                    Console.WriteLine("Enter elements of 1st array");
                    int[] a = new int[x];
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Now, enter elements of 2nd array");
                    int[] b = new int[x];
                    for (int j = 0; j <b.Length ; j++)
                    {
                        b[j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("--------------------------------------");
                    foreach (var item in a)
                    {
                        foreach (var item1 in b)
                        {
                            if (item != item1)
                            {
                                ans++;
                            }
                            else
                            {
                                mm++;
                            }
                        }
                        
                    }
                    Console.WriteLine(mm);
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

