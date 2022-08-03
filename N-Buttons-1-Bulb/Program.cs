using System;

namespace N_Buttons_1_Bulb
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
                    System.Console.WriteLine("Enter your data");
                    byte t = Byte.Parse(Console.ReadLine());

                    for (byte i = 0; i < t; i++)
                    {

                        byte counter = 0;

                        byte n = Byte.Parse(Console.ReadLine());
                        char[] s = Console.ReadLine().ToCharArray();
                        char[] r = Console.ReadLine().ToCharArray();

                        for (byte o = 0; o < n; o++)
                        {
                            if (r[o] != s[o])
                                counter++;
                        }

                        Console.WriteLine(counter % 2 == 0 ? '1' : '0');
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

