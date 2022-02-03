using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemStatement1
{
    class program
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person1[] persons = new Person1[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher1(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher1)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }

        public class Person1
        {
            protected string Name { get; set; }

            public Person1(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }

            ~Person1()
            {
                Name = string.Empty;
            }
        }

        public class Teacher1 : Person1
        {
            public Teacher1(string name) : base(name)
            {
                Name = name;
            }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }

        public class Student : Person1
        {
            public Student(string name) : base(name)
            {
                Name = name;
            }

            public void Study()
            {
                Console.WriteLine("Study");
            }
        }
    }
}
