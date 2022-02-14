using System;
using System.Collections.Generic;
using System.Text;

namespace day13
{
    class Replacingchar
    {
        static void Main2(string[] args)
        {
            string str1;
            char[] arr1;
            int length, i;
            length = 0;
            char ch;
            Console.Write("Enter the string : ");
            str1 = Console.ReadLine();
            length = str1.Length;
            arr1 = str1.ToCharArray(0, length); // Converts string into char array.

            Console.Write("\nAfter conversion, the string is: ");
            for (i = 0; i < length; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // check whether the character is lowercase
                    Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
                else
                    Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
            }
            Console.ReadLine();
        }
    }
}

