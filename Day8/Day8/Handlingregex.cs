using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExceptionHandling
{
    internal class Handlingregex
    {
        static void Main4(string[] args)
        {
            //this will return any pattern line ab,aab,aaab;
            //Regex re = new Regex("a*b");
            //this will return pattern like b,ab
            Regex re = new Regex("a?b");
            Match match = re.Match("aaaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Matched the value " + match.Value);
            }
        }
    }
}