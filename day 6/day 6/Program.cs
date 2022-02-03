using System;

namespace day_6
{
    //Base class
    class Vehicle //parent
    {
        public string brand = "TATA";
        public void honk()
        {
            Console.WriteLine("Honk");
        }
    }
    class Car : Vehicle //child or derived class
    {
        public string modelname = "SAFARI";
    }
    class InheritanceSample
    {
        public static void Main1()
        {
            Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand + "  " + car.modelname);
        }
    }
}
