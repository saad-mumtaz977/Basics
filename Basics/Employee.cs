using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Employee
    {
        private int Id;
        private string Name;
        private double Salary;

        static Employee() {
            Console.WriteLine("Static Constructor Called");
                }
        public Employee() { }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee(Employee obj) { 
            Id  = obj.Id;
            Name = obj.Name;
            Salary = obj.Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}00"; 
        }
        List<Employee> list = new List<Employee>(); 

    }
}

