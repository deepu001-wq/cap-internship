using System;
using System.Collections.Generic;
using System.Text;

namespace pattern_1
{
    class Class1
    {
         static void main (string[] args)

        {
            int rows, k = 1;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");


            }
        }
    }
}
