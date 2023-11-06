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
            Calcualator c1 = new Calcualator();
            Console.WriteLine(c1.addition(2, 6));
            Console.WriteLine(c1.divide(4, 10));
            Console.WriteLine(c1.multiply(10, 10));
            Console.WriteLine(c1.subtract(10, 10));
        }
    }
}
