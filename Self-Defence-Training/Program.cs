/*
 Problem
After the phenomenal success of the 36th Chamber of Shaolin, San Te has decided to start 37th Chamber of Shaolin. The aim this time is to equip women with shaolin self-defence techniques.

The only condition for a woman to be eligible for the special training is that she must be between 1010 and 6060 years of age, inclusive of both 1010 and 6060.

Given the ages of NN women in his village, please help San Te find out how many of them are eligible for the special training.

Input Format
The first line of input contains a single integer TT, denoting the number of test cases. The description of TT test cases follows.
The first line of each test case contains a single integer NN, the number of women.
The second line of each test case contains NN space-separated integers A_1, A_2,..., A_N ​
 , the ages of the women.
Output Format
For each test case, output in a single line the number of women eligible for self-defence training.

Sample 1:
Input


3
15 23 65
3
15 62 16
2
35 9

Output
2
2
1

 */

using System;

namespace Self_Defence_Training
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
                    Console.WriteLine("Welcome to san te 37th Chamber of Shaolin");
                    Console.WriteLine("Enter the no of Female who want to enroll");
                    int x=int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the age of each female");
                    int ageGreater = 0;
                    int agebelow = 0;
                    int[] y = new int[x];
                    for (int i = 0; i < y.Length; i++)
                    {
                        y[i] = int.Parse(Console.ReadLine());

                       if ((y[i]>10)&&(y[i]<60))
                        {
                            ageGreater++;
                        }
                        else
                        {
                            agebelow++;
                        }
                    }
                    Console.WriteLine("Total enrollment can be done is : "+" "+ageGreater);
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

