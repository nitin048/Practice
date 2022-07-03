/*
 Problem
For help on this problem, please check out our tutorial Input and Output (I/O)

Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, and Everything. More precisely...
rewrite small numbers from input to output. Stop processing input after reading in the number 42. All numbers at input are integers of one or two digits.

Sample Input:
1
2
88
42
99
Sample Output:
1
2
88
 */
using System;

namespace TEST
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
                    Console.WriteLine("Life, the Universe, and Everything");
                    Console.WriteLine("How many entries you want to give");
                    int x = int.Parse(Console.ReadLine());
                    int[] arr = new int[x];
                    Console.WriteLine("Enter values range 1-99");
                    for (int i = 0; i < x; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("-----------------------------------------");
                    foreach (var item in arr)
                    { 
                        if (item==42)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(item);
                        }
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

