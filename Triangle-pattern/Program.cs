/*
Program: [ Star Pyramid ]

that how to create a simple program for printing a Pyramid type output using C#.

output:

              **
             ****
            ******
           ********
          **********
         ************
        **************
       ****************
      ******************
     ********************
    **********************
   ************************
  **************************
 ****************************
******************************

logic:
Here (in below code) x is the total number of rows and each row contains x – i (rownumber) spaces and 2 * i (rownumber) stars.

 */


using System;

namespace Triangle_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= (x-i); j++)
                
                    Console.Write(" ");

                    for (int k = 1; k <=(i*2); k++)
                    
                        Console.Write("*");
                        Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

