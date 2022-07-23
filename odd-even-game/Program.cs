﻿using System;

namespace odd_even_game
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
                    int x = Convert.ToInt32(Console.ReadLine());
                    int x1 = 0, x2 = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(str[0]);
                        x2 = Convert.ToInt32(str[1]);


                        if ((x1+x2)%2==0 )
                        {
                            Console.WriteLine("Bob");
                        }
                        else
                        {

                            Console.WriteLine("Alice");
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

