using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class ChainingDemo
    {
        public ChainingDemo(int n) : this("hello")
        {
            Console.WriteLine("takes int");
        }

        public ChainingDemo(): this(1) 
        {
            Console.WriteLine("Takes nothing");
        }

        public ChainingDemo(string n)
        {
            Console.WriteLine("Takes string");
        }
    }
}
