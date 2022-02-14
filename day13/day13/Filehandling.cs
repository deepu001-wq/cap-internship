using System;
using System.IO;

namespace day13
{
    class Filehandling
    {
        static void Main3(string[] args)
        {
            ////write in a file

            //StreamWriter sw = new StreamWriter("C://Users//srinivasulu//Desktop//sample//example.txt");
            ////to write a line in buffer
            //sw.WriteLine("writing value in a file");
            ////write in output steam
            //sw.Flush();
            //sw.Close();
            StreamReader sr = new StreamReader("C://Users//srinivasulu//Desktop//sample//example.txt");
            //this is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
