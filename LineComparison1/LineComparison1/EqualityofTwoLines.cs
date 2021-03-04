using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison1
{
    class EqualityofTwoLines
    {
        static void Main(string[] args)
        {
            int x1 = 2, x2 = 4, y1 = 6, y2 = 2;
            int x3 = 4, x4 = 8, y3 = 3, y4 = 5;
            double length1 = 0;
            double length2 = 0;
            length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("length is: " + length1);
            Console.WriteLine("length is: " + length2);
        }
        
    }
}
