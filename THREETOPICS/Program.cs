/*

Problem
The Chef has reached the finals of the Annual Inter-school Declamation contest.

For the finals, students were asked to prepare 10 topics. However, Chef was only able to prepare three topics, numbered A,B and C — he is totally blank about the other topics.
This means Chef can only win the contest if he gets the topics A, B or C to speak about.

On the contest day, Chef gets topic X. Determine whether Chef has any chances of winning the competition.

Print "Yes" if it is possible for Chef to win the contest, else print "No".

You may print each character of the string in either uppercase or lowercase (for example, the strings yEs, yes, Yes, and YES will all be treated as identical).

Input Format
The first and only line of input will contain a single line containing four space-separated integers A, B, C, and X — the three topics Chef has prepared and the topic that was given to him on contest day.

Output Format
For each testcase, output in a single line "Yes" or "No".
You may print each character of the string in either uppercase or lowercase (for example, the strings yEs, yes, Yes, and YES will all be treated as identical).

Subtasks
Subtask #1 (100 points): Original constraints

Sample 1:
Input

2 3 7 3

Output
Yes
Explanation:
Chef had prepared the topics: 2, 3, 7. Chef gets to speak on the topic: 3. Since Chef had already prepared this, there is a chance that he can win the contest.

Sample 2:
Input

4 6 8 5

Output
No
Explanation:
Chef had prepared the topics: 4, 6, 8. Chef gets to speak on the topic: 5. Since Chef didn't prepare this topic, there is no chance that he can win the contest.

 */

using System;

namespace THREETOPICS
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
                    Console.WriteLine("Welcome to the final exam");
                    Console.WriteLine("Give speech on topic.\nenter the value");
                    int x = int.Parse(Console.ReadLine());
                    Random no = new Random();
                    int count = 3;
                    int win = 0;
                    int lose = 0;
                    int[] arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {

                        arr[i] = no.Next(10);
                    }
                    foreach (var item in arr)
                    {
                        if (item == x)
                        {
                            win++;
                        }
                        else
                        {
                            lose++;
                        }
                    }
                    if (win == 1)
                    {
                        Console.WriteLine("chef Win 🥳");
                    }
                    else
                    {
                        Console.WriteLine("chef lose 😩");
                    }
                    Console.WriteLine("Do you want play again?\nYes or No");
                    confirm = Console.ReadLine().ToLower();
                } while (confirm == "yes");

                Console.WriteLine("Thank you!👋🤠");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Here is the exception:--> "+" "+ex);
            }

            
        }
    }
}

