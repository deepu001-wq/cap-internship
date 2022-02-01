using System;

namespace pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
