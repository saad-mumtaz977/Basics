using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Calcualator
    {
        public int addition(int a, int b) { 
            return a + b;
        }

        public int subtract(int a, int b) {
            return (a - b);
        }

        public float divide(int a, int b) { 
            return (float) a / b;
        }

        public int multiply(int a, int b) { 
            return a * b;    
        }
    }
}
