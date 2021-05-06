using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Computation");
            Console.WriteLine("Enter the co-ordinates");
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x1:" + x1);
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y1:" + y1);
                Console.WriteLine("x1:" + x1 + "y1:" + y1);

                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x2:" + x2);
                int y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y2:" + y2);
                Console.WriteLine("x2:" + x2 + "y2:" + y2);

              
                double length1 = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
                Console.WriteLine("length of line 1:" + length1);

                
            }
        }
    }
}
