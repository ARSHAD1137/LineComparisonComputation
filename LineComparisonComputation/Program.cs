using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x3:" + x3);
                int y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y3:" + y3);
                Console.WriteLine("x3:" + x3 + "y3:" + y3);
                int x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x4:" + x4);
                int y4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y4:" + y4);
                Console.WriteLine("x4:" + x4 + "y4:" + y4);

                double length2 = Math.Sqrt(Math.Pow((y4 - y3), 2) + Math.Pow((x4 - x3), 2));
                Console.WriteLine("length of line 2:" + length2);


            }
        }
    }
}
