using System;
using System.Collections.Generic;
using System.Text;

namespace parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample(6);
            Sample(6, 7);
            Sample(6, 7, 8);

            NamedSample(z: 10, x: 2, y: 30);
        }
        public static void Sample(int x, int y = 10, int z = 10)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
        public static void NamedSample(int x, int y, int z)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
    }
}
