using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            while (num != 1)
            {
                res = res * num;
                num= num - 1;
            }
            Console.WriteLine("the factorial of the given number is:" +res);
        }
    }
}
