using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace day13
{
    class Filehandling2
    {
        static void Main(string[] args)
        {
            FileStream fout = new FileStream("file.txt", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fout);
            string name = "file";
            bw.Write(name);
            bw.Close();

            FileStream fin = new FileStream("file.txt", FileMode.Open);
            BinaryReader br = new BinaryReader(fin);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            //  string sample = br.ReadString();
            Console.WriteLine(br.ReadString());
            br.Close();



        }
    }
}
