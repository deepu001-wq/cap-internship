using System;
using System.Collections.Generic;
using System.Text;

namespace day_6
{
    
    class Problem5
    {
        public static void Main8(string[] args)
        {
            Car car = new Car(0);
            Console.Write("enter the value in umbers:");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }

        }
        public interface IVehicle
        {
            void Drive();

            bool Refuel(int amount);
            
        }
        public class Car:IVehicle
        {
            public int Fuel { get; set; }
            public Car(int fuel)
            {
                Fuel = fuel;
            }
            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("******************");
                }
                else
                {
                    Console.WriteLine("No Fuel.....");
                }
            }
           public  bool Refuel(int amount)
            {
                Fuel += amount;
                return true;

            }

        }
    }
}
