/*
 * https://www.codechef.com/submit/TLG
 */
using System;
using System.Collections.Generic;
namespace The_Lead_Game
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
                    Console.WriteLine("Welcome TLG");
                    Console.WriteLine("Enter the round");
                    int arrsize = 0;
                    arrsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now enter elements of player 1");
                    int[] player1 = new int[arrsize];
                    for (int i = 0; i < arrsize; i++)
                    {
                        player1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Now enter elements of player 2");
                    int[] player2 = new int[arrsize];
                    for (int i = 0; i < arrsize; i++)
                    {
                        player2[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("--------------------------------------------------------");
                    List<KeyValuePair<int, int>> Lead = new List<KeyValuePair<int, int>>();
                    int Tplayer1 = 0;
                    int Tplayer2 = 0;
                    for (int i = 0; i < arrsize; i++)
                    {
                        Tplayer1 += player1[i];
                        Tplayer2 += player2[i];

                        int diff = Math.Abs(Tplayer1-Tplayer2);
                        if (Tplayer1>Tplayer2)
                        {
                            
                            Lead.Add(new KeyValuePair<int, int>(1, diff));
                        }
                        else
                        {
                            Lead.Add(new KeyValuePair<int, int>(2, diff));
                        }
                        diff = 0;
                    }
                    int maxelement = 0;
                    int player = 0;
                    foreach (var item in Lead)
                    {
                        if (item.Value>maxelement)
                        {
                            maxelement = item.Value;
                            player = item.Key;
                        }
                        
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("THIS THE VALUE"+" "+player+" "+maxelement);
                    Console.WriteLine("-----------------------------------------------");
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

