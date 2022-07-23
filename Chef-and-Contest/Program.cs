/*
 https://www.codechef.com/submit/CHEFCONTEST
 */
using System;

namespace Chef_and_Contest
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
                    int x = Convert.ToInt32(Console.ReadLine()),x1=0,x2=0,y1=0,y2=0,chef=0,chefina=0;
                    
                    for (int i = 0; i < x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        x1 = Convert.ToInt32(str[0]);
                        x2 = Convert.ToInt32(str[1]);
                        y1 = Convert.ToInt32(str[2]);
                        y2 = Convert.ToInt32(str[3]);

                        chef = x1 + (y1 * 10);
                        chefina = x2 + (y2 * 10);
                        if (chef<chefina)
                        {
                            Console.WriteLine("Chef");
                        }
                        else if(chef == chefina)
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

