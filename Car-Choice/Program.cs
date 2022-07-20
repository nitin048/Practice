/*
 https://www.codechef.com/submit/CARCHOICE?tab=submissions
 */

using System;

namespace Car_Choice
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
                    double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        x1 = Convert.ToDouble(str[0]);
                        x2 = Convert.ToDouble(str[1]);
                        y1 = Convert.ToDouble(str[2]);
                        y2 = Convert.ToDouble(str[3]);

                        double diesel = (y1 / x1);
                        double petrol = (y2 / x2);

                        if (diesel < petrol)
                        {
                            Console.WriteLine("-1");
                        }
                        else if (diesel == petrol)
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("1");
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

