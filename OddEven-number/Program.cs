/*
 Problem:

print Odd and even numbers from the given string.

input: 
string x = "1,2,3,4,5,56,6,7,8,22,45,77,88";

output:

Even no are:
2
4
56
6
8
22
88
-----------------------------------------------
Odd no's are:
1
3
5
7
45
77

 */



using System;

namespace OddEven_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "1,2,3,4,5,56,6,7,8,22,45,77,88";
            string[] n = x.Split(",");
            int[] v = Array.ConvertAll(n,int.Parse);
            Console.WriteLine("Even no's are:");
            foreach (var item in v)
            { 
                if (item%2==0)
                {
                  
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Odd no's are:");
            foreach (var item in v)
            {
                if (item%2==1)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

