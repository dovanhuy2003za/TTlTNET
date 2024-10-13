using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_TTnet
{
    internal class Person
    {
        protected int age;
        public void loichao()
        {
            Console.WriteLine("hello");
        }
        public void setAge(int n)
        {
            age = n;
        }
    }
}
