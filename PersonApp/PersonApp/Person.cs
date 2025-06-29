using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{

    enum BMI { UNDERWEIGHT, NORMAL, OVERWEIGHT }
    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public double Height { get; set; } = 5;
        public double Weight { get; set; } = 50;


        public Person(int  id,string name,int age, double height, double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public Person(int  id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public double CalcBMI()
        {
            double bmi = Weight / (Height * Height);
            return bmi;
        }

        public void Bodytype()
        {
            if (CalcBMI() < 18.5) Console.WriteLine(BMI.UNDERWEIGHT);
            if (CalcBMI() >= 18.5 && CalcBMI() <= 24.5) Console.WriteLine(BMI.NORMAL);
            if (CalcBMI() >= 25) Console.WriteLine(BMI.OVERWEIGHT);
        }
    }
}
