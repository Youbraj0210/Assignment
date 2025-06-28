using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetGravityEnum
{
    enum Planet
    {
        MERCURY = (int)(0.38 * 100),
        VENUS = (int)(0.91 * 100),
        EARTH = (int)(1.00 * 100),
        MARS = (int)(0.37 * 100),
        SATURN = (int)(2.34 * 100),
        JUPITER = (int)(1.06 * 100),
        URANUS = (int)(0.92 * 100),
        NEPTUNE = (int)(1.19 * 100),
    }
    internal class PlanetGravity
    {
        public static void GravityCalc(double weightOnEarth)
        {
            foreach (Planet planet in Enum.GetValues(typeof(Planet)))
            {
                double relativeGravity = (double)planet / 100;
                double equivWeight = weightOnEarth * relativeGravity;
                Console.WriteLine($"Weight on {planet}: {equivWeight} kg");
            }
        }
    }
}
