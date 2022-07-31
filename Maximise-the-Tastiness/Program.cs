using System;

namespace Maximise_the_Tastiness
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
                    int x = Convert.ToInt32(Console.ReadLine()), x1 = 0, x2 = 0,x3=0,x4=0,a=0,b=0,c=0,d=0;

                    for (int i = 0; i < x; ++i)
                    {
                        string[] split = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(split[0]);
                        x2 = Convert.ToInt32(split[1]);
                        x3 = Convert.ToInt32(split[2]);
                        x4 = Convert.ToInt32(split[3]);
                        a = x1 + x3;
                        b = x1 + x4;
                        c = x2 + x3;
                        d = x2 + x4;

                        int[] arr1 = { a, b };
                        int[] arr2 = { c, d };
                        Array.Reverse(arr1);
                        Array.Reverse(arr2);
                        Array.Sort(arr1);
                        Array.Sort(arr2);
                        if (arr1[1] >arr2[1])
                        {
                            Console.WriteLine(arr1[1]);
                        }
                        else
                        {
                            Console.WriteLine(arr2[1]);
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

