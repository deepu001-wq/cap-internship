using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace xml
{
    class xmlread
    {
        static void Main1(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("C://Users//srinivasulu//source//repos//sample.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        Console.WriteLine(reader.ReadString());
                        Console.WriteLine(reader.Name.ToString());

                    }

                }
            }
        }
    }
}
