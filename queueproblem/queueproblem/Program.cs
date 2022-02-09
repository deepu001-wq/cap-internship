using System;
using System.Collections;

namespace queueproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }


    public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
        }
  
