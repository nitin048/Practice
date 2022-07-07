using System;

namespace LifeExpactency
{
    class Program
    {
        public static void dob ()
            {


            }

        static void Main(string[] args)
        {
            try
            {
                string confrim;
                do
                {
                    DateTime birthDate = new DateTime(2000, 3, 1);
                    int age = (int)Math.Floor((DateTime.Now - birthDate).TotalDays / 365.25D);
                    Console.WriteLine(age);
                    //Console.WriteLine("check your life expectency");
                    //Console.WriteLine("Enter your DOB");
                    //Console.WriteLine("Enter day");
                    //int day = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter month");
                    //int month = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter year");
                    //int year = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Do you want to run the prgm again?🤔\nYes or No");
                    confrim = Console.ReadLine().ToLower();
                } while (confrim == "yes");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Thank you!!👋");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!!!☠️");
                Console.WriteLine("\nHere is the exception:->" + " " + ex);
            }
        }
    }
}

