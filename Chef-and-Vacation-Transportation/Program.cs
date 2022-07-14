/*
 https://www.codechef.com/submit/CHEFTRANS
 */
using System;

namespace Chef_and_Vacation_Transportation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string confrim;
                do
                {
                    Console.WriteLine("Enter your constrain value and input values");
                    
                    int x = Convert.ToInt32(Console.ReadLine()), ac = 0, bc = 0, cc = 0;
                    for (int i = 0; i < x; ++i)
            {
                string[] split = Console.ReadLine().Split(' ');
                ac = Convert.ToInt32(split[0]);
                bc = Convert.ToInt32(split[1]);
                cc = Convert.ToInt32(split[2]);

                if ((ac + bc) > cc)
                {
                    Console.WriteLine("TRAIN");
                }
                else if ((ac + bc) < cc)
                {
                    Console.WriteLine("PLANEBUS");

                }
                else if ((ac + bc) == cc)
                {
                    Console.WriteLine("EQUAL");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
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


