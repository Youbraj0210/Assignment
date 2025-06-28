namespace PlanetGravityEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight on Earth: ");
            double weight = double.Parse(Console.ReadLine());
            PlanetGravity.GravityCalc(weight);
        }
    }
}
