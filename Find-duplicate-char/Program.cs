using System;

namespace Find_duplicate_char
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
                    Console.WriteLine("Enter your string ");
                    string str1 = Console.ReadLine();
                    char[] str = str1.ToCharArray();
                    Console.WriteLine( "--------------------------------------------------");
                    for (int i = 0; i < str.Length; i++)
                    {
                        int count = 0;
                        for (int j = i + 1; j < str.Length - 1; j++)
                        {
                            if (str[i] == str[j] && str[i] != ' ')
                            {
                                count++;
                                str[j] = '0';
                            }
                        }

                        if (count > 0 && str[i] != '0')
                        {
                            Console.WriteLine(str[i]);
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

