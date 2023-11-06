using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
           Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Test";
            employee.show();

        }
    }
}
