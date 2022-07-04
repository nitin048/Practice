using System;

namespace Wordle
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
                    Console.WriteLine("Lets play Wordle");
                    Console.WriteLine("Enter the size of an array");
                    int x = 0;
                    x = int.Parse(Console.ReadLine());
                    string[] c = new string[x];
                    Console.WriteLine("Enter elements of 1st array");
                    string[] a = new string[x];
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Now, enter elements of 2nd array");
                    string[] b = new string[x];
                    for (int j = 0; j < b.Length; j++)
                    {
                        b[j] = Console.ReadLine();
                    }
                    for (int i = 0; i < x; i++)
                    {
                        if (a[i] == b[i])
                        {
                            c[i]= "G";
                        }
                        else
                        {
                            c[i] = "B";
                        }
                    }
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("\n");
                    foreach (var item in c)
                    {
                        Console.Write(item);
                        
                    }
                    Console.WriteLine("\n");
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

