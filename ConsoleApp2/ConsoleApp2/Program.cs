using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 200;

            // boxing
            object obj = num;

            // value of num to be change
            num = 10;
            //unboxing
            int i = (int)obj;

            Console.WriteLine
            ("Value - type value of num is : {0}", num);
            Console.WriteLine
            ("Object - type value of obj is : {0}", obj);
            Console.WriteLine
            ("value of i is : {0}", +i);


        }
    }
}
