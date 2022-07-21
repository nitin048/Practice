using System;

namespace Total_Expenses
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
                    double x1 = 0, x2 = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        x1 = Convert.ToDouble(str[0]);
                        x2 = Convert.ToDouble(str[1]);
                        

                        double discount = (x1*x2);
                        double discount1 = (discount/10);
                        double discount2 = discount - discount1;

                        if (x1 < 1000)
                        {
                            Console.WriteLine(x1 * x2);
                        }
                        else 
                        {

                            Console.WriteLine(discount1);
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

