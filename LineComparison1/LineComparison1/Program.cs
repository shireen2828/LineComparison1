using System;

namespace UC1_LineComparison1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2, x2 = 4, y1 = 6, y2 = 2;
            double length = 0;
            length=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length of the line is: " + length);
        }
    }
}
