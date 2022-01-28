using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype [] name of the variable
            int[] cnumbers = { 10, 12, 13, 14 };
            for(int i=0;i<cnumbers.Length;i++)
            {
                Console.WriteLine(cnumbers[i]);
            }
        }
    }
}
