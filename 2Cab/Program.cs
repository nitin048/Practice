using System;

namespace _2Cab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for y");
            int y = int.Parse(Console.ReadLine());
            if ((x < 100) && (x < y))
            {
                Console.WriteLine("FRIST");
            }
            else if ((x == y) && (x < 100) && (y < 100))
            {
                Console.WriteLine("ANY");
            }
            else if ((y < 100) && (x > y))
            {
                Console.WriteLine("SECOND");
            }
            else
            {
                Console.WriteLine("incorrect ");
            }
        }
    }
}

