using System;

namespace Day8
{
    internal class Program
    {
        public class sample<T>
        {
            //field
            private T data;

            //property
            public T value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        static void Main1(string[] args)
        {
            sample<string> name = new sample<string>();
            name.value = "Deepu";

            sample<float> version = new sample<float>();
            version.value = 5.0F;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);
            
        }
    }
}
