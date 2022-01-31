using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)

        {
            object sampleObj = new object();
            object sampleObj2 = new object();
            int i = 21;

            bool result = Equals(sampleObj, sampleObj2);
            Console.WriteLine(result);
            Type t1 = sampleObj.GetType();
            Type t2 = i.GetType();
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine(t2.BaseType);
        }
    }
}
