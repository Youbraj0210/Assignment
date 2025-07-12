using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal abstract class SalariedEmployee
    {
        public double BaseSalary { get; set; }
        public abstract double CalculateSalary();
    }
}
