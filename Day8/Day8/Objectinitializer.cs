using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class Objectinitializer
    {
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
    
    public static void Main2()
    {

            Employee std = new Employee()
        {
                EmployeeID = 1,
                EmployeeName = "Vikash",
                Age = 27,
                Address = "Dummy "
        };
        Console.WriteLine("Employee Information");
        Console.WriteLine(std.EmployeeID);
        Console.WriteLine(std.EmployeeName);
        Console.WriteLine(std.Age);
        Console.WriteLine(std.Address);
    }
    }
}
