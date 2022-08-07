using System;

namespace Nearest_Court
{
    class Program
    {
        static void Main(string[] args)
        {
			int T = int.Parse(Console.ReadLine());
			for (int i = 0; i < T; i++)
			{
				string[] lines = Console.ReadLine().Split(' ');
				int x = int.Parse(lines[0]);
				int y = int.Parse(lines[1]);
				int diff = Math.Abs(x - y);
				if (diff == 1)
				{
					Console.WriteLine(diff);
				}
				else
				{
					if (diff % 2 == 0)
					{

						Console.WriteLine(diff / 2);
					}
					else
					{
						Console.WriteLine((diff / 2) + 1);
					}
				}
			}   
		}
    }
}

