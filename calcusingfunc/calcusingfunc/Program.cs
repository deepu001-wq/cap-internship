using System;

namespace calcusingfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an option(1,2,3):");
            int op = Convert.ToInt32(Console.ReadLine());
            float result=0;
            switch(op)
            {
                case 1:
                    {
                        result = Add(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = Mult(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = Sub(num1, num2);
                        break;

                    }
                default:
                    
                        Console.WriteLine("Invalid operator");
                        break;
                    
                    
                    
                    


            }
            Console.WriteLine("the result is {0}",result);
            Console.ReadKey();
        }
        //add
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public static int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

    }
}
