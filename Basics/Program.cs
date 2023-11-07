using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basics
{
    public delegate void myDelegate();
    public delegate void myDelegate2(string s); 

    internal delegate void myDelegate3();
    internal delegate string myDelegate4();

    internal delegate void myDelegate5(string str);

    public class Square {
        public int side;

        public Square(int side)
        {
            this.side = side;
        }

        public void GetArea() {
            Console.WriteLine(side * side);
        }

        public void GetParameter() { 
            Console.WriteLine(4*side);
        }

    
    }
    internal class Program
    {
        public static void print() {
            Console.WriteLine("Hello World"); 
        }

        public static void print(string s) { 
            Console.WriteLine(s);
        }
        public static void Main(string[] args)
        {
            myDelegate d1 = new myDelegate(print);
            d1();
            myDelegate2 d2 = new myDelegate2(print);
            d2("My name is Saad");

            Square s1 = new Square(100);   
            
            //multicast delegate
            myDelegate3 d3 = new myDelegate3(s1.GetArea);
            d3 += s1.GetParameter;
            d3();

            //Anonymous Methods
            myDelegate4 d4 = new myDelegate4(delegate () {
                return "this is from an anoymous method";
            });

            Console.WriteLine(d4());
            
            //lambda Expression
            myDelegate5 d5 = (name) =>
            {
                Console.WriteLine("Hello, " + name + ", How are you doing today?");
            };

            d5("Saad");
        }
    }
}
