using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Y");
            int y = int.Parse(Console.ReadLine());

            try
            {
                if ((x < 100) && (y < 100))
                {
                    int ans = Math.Abs(x - y);
                    Console.WriteLine(ans);
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

