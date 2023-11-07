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
    internal class Program
    {
        static void func1() {
            long counter = 0;
            for (int i = 0; i < 1000000000; i++) {
                counter++;
            } 
            Console.WriteLine("Counter Value from 1 is: " + counter);
        }

        static void func2()
        {
            long counter = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                counter++;
            }
            Console.WriteLine("Counter Value from 2 is: " + counter);
        }
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            func1();
            func2();
            s1.Stop();

            Console.WriteLine("Total time in single threaded model: " + s1.ElapsedMilliseconds);

            Stopwatch s2 = new Stopwatch();
            Console.WriteLine("Now making Threads");

            ThreadStart obj1 = new ThreadStart(func1);
            Thread t1 = new Thread(obj1);

            ThreadStart obj2 = new ThreadStart(func2);
            Thread t2 = new Thread(obj2);
            t1.Start();t2.Start();
            t1.Join();t2.Join();

            s2.Stop();
            Console.WriteLine("Total time in multi threaded model: " + s2.ElapsedMilliseconds);
        }
    }
}
