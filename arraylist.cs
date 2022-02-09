using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace day_10
{
    class arraylist
    {
        static void Main5(string[] args)
        {
            ArrayList al = new ArrayList();
            string str = "sample";
            int x = 7;
            DateTime dt = DateTime.Now;

            al.Add(x);
            al.Add((DateTime)dt);
            al.Add(str);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }


            Hashtable ht = new Hashtable();
            SortedList Sl = new SortedList();
            Stack s = new Stack();
            Queue q = new Queue();
        }
    }
}
