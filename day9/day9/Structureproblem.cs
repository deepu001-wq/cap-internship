using System;
using System.Collections.Generic;
using System.Text;

namespace day9
{
    public struct Car
    {
        public string Model;
        public int year;
        
    }
    class Structureproblem
    {
        public static void Main4(string[] args)
        {
            int total = 3;
            Car[] cars = new Car[total];

            for (int i = 0; i < total; i++)
            {
                cars[i] = new Car()
                {
                    Model = Console.ReadLine(),
                    year = int.Parse(Console.ReadLine())
                };
            }
            for (int i = 0; i < total - 1; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (cars[i].year > cars[j].year)
                    {
                        var aux = cars[i];

                        cars[i] = cars[j];
                        cars[j] = aux;
                    }
                }

            }
            for (int i = 0; i < total; i++)
            {
                var car = cars[i];
                Console.WriteLine("Model: " + car.Model + ", " +
                    "Year of production: " + car.year);
            }
        }
    }
}
