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
            /* 
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
            Console.WriteLine(z)
            */



            //DATA TYPES
            /*
            Console.WriteLine($"Byte => Minimum Range:{byte.MinValue} and Maximum Range:{byte.MaxValue}");
            Console.WriteLine($"Integer => Minimum Range:{int.MinValue} and Maximum Range:{int.MaxValue}");
            Console.WriteLine($"Float => Minimum Range:{float.MinValue} and Maximum Range:{float.MaxValue}");
            Console.WriteLine($"Long => Minimum Range:{long.MinValue} and Maximum Range:{long.MaxValue}");
            Console.WriteLine($"Double => Minimum Range:{double.MinValue} and Maximum Range:{double.MaxValue}");
            Console.ReadKey();  */

            string s1 = "saad mumtaz";
            string s2 = s1;

            //now s2 will point to a new string object on heap
            s2 = "saad mumtaz khan";
            Console.WriteLine(s1);


            int[] arr = { 1, 2, 5, 6 };
            int[] arr2 = arr;

            arr2[1] = 3;

            Console.WriteLine(arr[1]);

            //type casting
            int a = 12;
            float f1 = a;  //implicit

            float f2 = 3.8971f;
            int b = (int) f2; //explicit


            //through helper methods
            string str1 = "43";
            int c = Convert.ToInt32(str1);
            Console.WriteLine(c);   


        }
    }
}
