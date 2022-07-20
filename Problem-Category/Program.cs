/*
 https://www.codechef.com/submit/PROBCAT
 */
using System;

namespace Problem_Category
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string confirm;
                do
                {
                    Console.WriteLine("Enter your array size and values?");
                    int x = Convert.ToInt32(Console.ReadLine()), a = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        
                        if (1<= a && a<100)
                        {
                            Console.WriteLine("Easy");
                        }
                        else if(100 <= a && a < 200)
                        {
                            Console.WriteLine("medium");
                        }
                        else if(200 <= a && a <= 300)
                        {
                            Console.WriteLine("Hard");
                        }
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Do you want to repeat the program again?\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm == "yes");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Here is the exception :->" + " " + ex);
            }
        }
    }
}

