using System;

namespace COURSEREG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum capacity of students");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Students alredy enrolled");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of student who want to enroll");
            int x = int.Parse(Console.ReadLine());

            try
            {
                if ((x<m)&&(y<m)&&(x<y))
                {
                    if ((x<=(Math.Abs(m-y))))
                    {
                        Console.WriteLine("students are enrolled: YES");
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry batch is running with its full capacity : NO");
                    }
                }
                else
                {
                    Console.WriteLine("somthing went wrong!");
                }
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Remaining seats  avialable is :" +" "+ (Math.Abs(x - (m - y))));
        }
    }
}

