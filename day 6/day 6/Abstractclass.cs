using System;
using System.Collections.Generic;
using System.Text;

namespace day_6
{
    abstract class SampleA
    {
        public SampleA()
        {

        }

        abstract public void show();

    }
    class SampleB : SampleA
    {
        public SampleB()
        {

        }
        //overriding
        public override void show()
        {

        }
    }
    class Abstarctclasses
    {
        static void Main5(string[] args)
        {
            SampleB b = new SampleB();
        }
    }
}
