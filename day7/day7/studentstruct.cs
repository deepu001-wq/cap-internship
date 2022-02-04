using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    public struct Student
    {
        public string Name;
        public int class1;
        public string Gender;
        public void Getdata()
        {
            Console.Write("enter the name:");
            string Name=Console.ReadLine();
            Console.Write("enter the class:");
            int class1=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the gender:");
            string Gender=Console.ReadLine();

        }
        public void Showdata()
        {
            Console.WriteLine("the details are:" +Name);



        }



    }
    class studentstruct
    {
        
        public static void Main6(string[] args)
        {
            Student student = new Student();
            student.Getdata();
            
            student.Showdata();
        }
    }
}
