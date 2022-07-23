/*
 https://www.codechef.com/submit/DRUNKALK
 */
using System;
using System.Text;

namespace DrunkAlcoholic
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
                    int input_1 = Convert.ToInt32(Console.ReadLine()), input_2 = 0, answer = 0;
                    for (int x = 0; x < input_1; ++x)
                    {
                        input_2 = Convert.ToInt32(Console.ReadLine());
                        answer = input_2 * 3;
                        input_2 /= 2;
                        answer -= input_2 * 4;
                        Console.WriteLine(answer);
                    }
                    Console.ReadLine();

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

