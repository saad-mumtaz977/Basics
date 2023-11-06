using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Employee
    {

        private int _id = 0;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value >= 0)
                {
                    _id = value;
                }
                else
                {
                    _id = 9999;
                }
            }
        }

        private string _name = "";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    _name = "";
                }
            }
        }


        public void show() {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
        }

    }
}

