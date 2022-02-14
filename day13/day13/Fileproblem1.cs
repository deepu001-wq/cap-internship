using System;
using System.IO;

namespace day13
{
    class Fileproblem1
    {
        static void Main(string[] args)
        {


            string path = "C://Users//srinivasulu//Desktop//sample//file.txt";
            string Text = "Hello and Welcome";
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);
            }
        }
    }

}
