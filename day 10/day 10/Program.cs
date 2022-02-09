using System;
using System.Collections.Generic;
using System.Text;
namespace day_10
{
    class Program
    {
        static void Main1(string[] args)
        {
            
            
            Dictionary<string, string> PL = new Dictionary<string, string>();
           PL.Add("S112", "rina");
           PL.Add("S1123", "tina");
           PL.Add("S1125", "mina");
            Console.WriteLine("student details");
            foreach (KeyValuePair<string, string> ele1 in PL)
            {
                
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            


        }
    }
}
