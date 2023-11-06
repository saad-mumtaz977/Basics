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
            //console class is a static class 
            //properties of console class
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "C# basics";

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);


            int x = 45;
            Console.WriteLine(x);

            Console.Write("Enter any number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entrered: " +  y);

            //readkey and read method
            Console.WriteLine("Enter a no to get its ASCII value");
            int z = Console.Read();
            Console.WriteLine(z);
        }
    }
}
