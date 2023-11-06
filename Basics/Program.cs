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
            for (int i = 0; i < 10; i++) {
                if (i == 5)
                {
                    Console.WriteLine("Counter is at " + i++);
                    continue;
                }
                else if (i > 5) {
                    Console.WriteLine("Counter has reached above 5");
                }

                else
                {
                    Console.WriteLine("Counter has not reached 5 yet");
                }
            }


            int y = 1;
            while (y <= 10) { 
                Console.WriteLine($"5 x {y} = {5*y}");
                y++;
            }

            Console.WriteLine("Enter No between 1 - 5 (-1 to exit)");
            string choice = Console.ReadLine();
            if (choice == "-1") {
                goto stmt9;
            }

            switch (choice) {

                case "1":
                    Console.WriteLine("you choose one");
                    break;
                case "2":
                    Console.WriteLine("you choose two");
                    break;
                case "3":
                    Console.WriteLine("you choose three");
                    break;
                case "4":
                    Console.WriteLine("you choose four");
                    break;
                case "5":
                    Console.WriteLine("you choose five");
                    break;
                default: 
                    Console.WriteLine("Invalid choice");
                    break;
            }

        stmt9:
            return;
        }
    }
}
