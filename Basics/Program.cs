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
    public enum Toyota { 
        Yaris,
        Altis,
        Grande,
        Cross,
        Revo,
        Fortuner,
        LandCruiser
    } 

    public class Car
    {
        public Toyota toyota;

        public Car(int i) {
            toyota = (Toyota)i;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car(1); //Altis
            Car c2 = new Car(0); //Yaris
            Car c3 = new Car(2); //Grande
            Car c4 = new Car(3); //cross
            Car c5 = new Car(6); //landcruiser

            Console.WriteLine(c1.toyota);
            Console.WriteLine(c2.toyota);
            Console.WriteLine(c3.toyota);
            Console.WriteLine(c4.toyota);
            Console.WriteLine(c5.toyota);
        }
    }
}
