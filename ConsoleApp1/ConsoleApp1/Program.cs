using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string operand;
            float answer;
            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            switch (operand)
            {

                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

        }

    }





}
   