using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace day_10
{
    class Listuppercase
    {
        static void Main6(string[] args)
        {
            Console.Write("enter the string:");
            List<string> mylist = test(new List<string>(new string[] { Console.ReadLine() }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
    }
}
