using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            const double Balance = 120.00;
            const double intrest = 0.50;
            Console.WriteLine("Enter the amount you want to withdraw ");
            double x = double.Parse(Console.ReadLine());

            if ((x % 5 == 0) && (x <= Balance))
            {
                double Balleft = Math.Abs(Balance - (x + intrest));
                Console.WriteLine("Remaining amount : " + " " + Balleft);
            }
            else
            {
                Console.WriteLine("Retry,Incorrect Withdrawal Amount (not multiple of 5)");
            }

        }
    }
}

