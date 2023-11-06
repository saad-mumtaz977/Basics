using System;
using System.Collections;
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

            //boxing 

            int myVal = 10;
            object myObj = myVal;

            //unboxing
            int myVal2 = (int)myObj;


            //using arraylist

            ArrayList arrL = new ArrayList();
            arrL.Add(1);
            Console.WriteLine(arrL.Capacity);
            arrL.Add(2);arrL.Add(3);arrL.Add(4);
            arrL.Add(9);
            Console.WriteLine(arrL.Capacity);


            //using hashtable
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Saad");
            ht.Add("EmpId", 07);
            ht.Add("Salary", 1000.000);

            foreach (var key in ht.Keys) { 
                Console.WriteLine(key + " : " + ht[key]);            
            }

            //using List
            List<int> myList = new List<int>(); 
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);

            myList.Remove(9);
            myList.RemoveAt(4);

            foreach (var i in myList) {
                Console.WriteLine(i);
            }

            //using Dictionary

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary[1] = "Hello";
            myDictionary[2] = "People";
            myDictionary[3] = "78";
      }




    }
}
