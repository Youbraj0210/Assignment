using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class Child : Parent
    {
        public string College { get; set; } = "LTCE";

        public Child()
        {
            Height = 5.2;
            Console.WriteLine("this is the child Constructor!");
        }

        public Child(int id, string name, double height, string college) : base(id, name, height)
        {
            College = college;
        }

        public override string ToString()
        {
            base.ToString();
            Console.WriteLine(College);
            return College;
        }
    }
}
