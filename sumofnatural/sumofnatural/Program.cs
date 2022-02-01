using System;

namespace sumofnatural
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
