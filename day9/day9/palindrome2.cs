using System;
using System.Collections.Generic;
using System.Text;

namespace day9
{
    class palindrome2
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("enter a string:");
            string s = Console.ReadLine();
            string rev = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
            {
                Console.WriteLine("String is Palindrome", s, rev);
            }
            else
            {
                Console.WriteLine("String is not Palindrome ", s, rev);
            }
        }
    }
}
