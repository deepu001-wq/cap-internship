using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    public struct Person1
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    class Structvsenum
    {
        public static void Main1()
        {
            Person1 person;
            person.Name = "Sameer";
            person.Age = 21;
            person.Weight = 70;

            Console.WriteLine("Data is stored in person Name:" + person.Name);
            Console.WriteLine("Data is stored in person Age:" + person.Age);
            Console.WriteLine("Data is stored in person Weight" + person.Weight);
        }
    }
}
