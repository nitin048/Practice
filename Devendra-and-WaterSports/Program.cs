/*
 https://www.codechef.com/submit/DEVSPORTS
 */
using System;

namespace Devendra_and_WaterSports
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
                    int x = Convert.ToInt32(Console.ReadLine()),  z= 0,y=0,a=0,b=0,c=0,leftamt=0,result=0;
                    for (int i = 0; i <x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        z = Convert.ToInt32(str[0]);
                        y = Convert.ToInt32(str[1]);
                        a = Convert.ToInt32(str[2]);
                        b = Convert.ToInt32(str[3]);
                        c = Convert.ToInt32(str[4]);
                        leftamt = Math.Abs(z - y);
                        result = (a + b + c);
                        
                        if (leftamt>=result)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Do you want to repeat the program again?\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm=="yes");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Here is the exception :->"+" "+ex);
            }
        }
    }
}

