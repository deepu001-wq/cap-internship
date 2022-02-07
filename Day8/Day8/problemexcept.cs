using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OopsConcepts2
{
    class problemexcept
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input->");
            string a = Console.ReadLine();
            Regex re = new Regex("[0-9]{4}$");
            Match match = re.Match(a);
            if (match.Success)
            {
                Console.WriteLine("Success!!!");
            }
            else
            {
                Console.WriteLine("Input valid string");
            }
        }
    }
}