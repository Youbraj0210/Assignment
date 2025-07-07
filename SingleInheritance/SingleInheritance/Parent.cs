using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class Parent
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "Youbraj";
        public double Height { get; set; } = 5.5;

        public Parent()
        {
            Console.WriteLine("this is the constructor of the parent class!");
        }

        public Parent(int id, string name, double height)
        {
            Id = id;
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            string str = $"id: {this.Id} name: {this.Name} height: {this.Height}";
            Console.WriteLine(str);
            return str;
        }
    }
}
