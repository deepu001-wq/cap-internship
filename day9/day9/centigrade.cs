﻿using System;
using System.Collections.Generic;
using System.Text;

namespace day9
{
    class centigrade
    {
        public static void Main2(string[] args)
        {


            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}
