using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        static Program() {
            Console.WriteLine("Program Class Static Constructor Called");
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "ABC", 2900.000);
            Employee employee2 = new Employee(102, "ABC", 2900.000);
            Employee employee3 = new Employee(103, "ABC", 2900.000);
            Employee employee4 = new Employee(105, "ABC", 2900.000);
            Employee employee5 = new Employee(employee4);

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);
            Console.WriteLine(employee5);
      }




    }
}
