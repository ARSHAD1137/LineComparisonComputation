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

                if (length1 == length2)
                {
                    Console.WriteLine("line 1 is equal line 2");
                }
                else if (length1 >= length2)
                {
                    Console.WriteLine("line 1 is greater than line 2");
                }
                else
                {
                    Console.WriteLine("line 1 is smaller than line 2");
                }
            }
        }
    }
}
