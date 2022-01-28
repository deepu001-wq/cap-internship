using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
            string s = Console.ReadLine();
            string rev= string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
            {
                Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", s, rev);
            }
            else
            {
                Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", s, rev);
            }
        }
    }
}
