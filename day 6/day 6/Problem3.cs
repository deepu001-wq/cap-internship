using System;
using System.Collections.Generic;
using System.Text;

namespace day_6
{
    
    class program
    {

        static void Main7()
        {
            Dog dog = new Dog();
            Console.Write("what is doggys name:");
            Console.ReadLine();
            dog.SetName(Console.ReadLine());
           
            Console.WriteLine(dog.GetName());

            
            dog.Eat();
            

        }
        public abstract class Animal
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public abstract void Eat();
        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("the dog is eating");
            }
        }

    }
       
}

