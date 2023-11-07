using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        public static void test1(){
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: " + i);
            }
            Console.WriteLine("t1 thread is exiting");
        
        }

        public static void test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 2: " + i);
                if( i == 50) { 
                    Console.WriteLine("t2 Thread going to Sleep");
                    //Thread.Sleep(5000);
                    Console.WriteLine("t2 thread Waking Up");
                }
            }
            Console.WriteLine("t2 Thread is exiting");
        }

        public static void test3(object max)
        {
            int max_updated = Convert.ToInt32(max);
            for (int i = 0; i < max_updated; i++)
            {
                Console.WriteLine("Test 3: " + i);
            }
            Console.WriteLine("t3 thread is exiting");
        }


        public void ThreadLockingDemo() {
            lock(this) {
                Console.Write("[C# is an ");
                Thread.Sleep(5000);
                Console.Write("object oriented language]\n");
            }            
        }

        static void Main(string[] args) {
            Console.WriteLine("Main Thread Started");
            
            Thread t1 = new Thread(test1);

            ThreadStart obj = new ThreadStart(test2);
            Thread t2 = new Thread(obj);

            ParameterizedThreadStart Pobj = new ParameterizedThreadStart(test3);
            Thread t3 = new Thread(Pobj);

            //t1.Priority = ThreadPriority.Highest;
            t1.Start();t2.Start();t3.Start(67);
            t1.Join();t2.Join();t3.Join();

            Program p1 = new Program();

            ThreadStart obj2 = new ThreadStart(p1.ThreadLockingDemo);
            Thread t4 = new Thread(obj2);
            t4.Priority = ThreadPriority.Highest;
            t4.Start();


            Thread t5 = new Thread(p1.ThreadLockingDemo);
            t5.Start();
            t4.Join();t5.Join();

            
            Console.WriteLine("Main Thread Exiting");
        }
    }
}
