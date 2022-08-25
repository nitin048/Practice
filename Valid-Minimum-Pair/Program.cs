using System;

namespace Valid_Minimum_Pair
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string i = "heater";
            string o = "reheat";
            char[] char1 = i.ToLower().ToCharArray();
            char[] char2 = o.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string v1 = new string(char1);
            string v2 = new string(char2);
            if (v1 == v2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }




        }
    }


}

