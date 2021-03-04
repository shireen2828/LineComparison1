using System;

namespace UC3_CompareTwoLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2, x2 = 4, y1 = 6, y2 = 2;
            int x3 = 3, x4 = 8, y3 = 4, y4 = 5;
            double length1 = 0;
            double length2 = 0;
            length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            if (length1 == length2)
                Console.WriteLine("length is equal");
            else if (length1 > length2)
                Console.WriteLine("length1 is greater");
            else
                Console.WriteLine("length1 is smaller");
            Console.ReadKey();
        }
    }
}
