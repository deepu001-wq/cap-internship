using System;
using Calculator;
namespace day14
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine(cal.sum(1, 2));
        }
    }
}
