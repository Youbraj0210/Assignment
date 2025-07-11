namespace WaterBillGenerator
{
    internal class Program
    {
        static int CalculateMeterBill(in int units)
        {
            int Meter_charge = 75;
            int charge;


            if (units <= 100)
            {
                charge = units * 5;
            }
            else if (units <= 250)
            {
                charge = units * 10;
            }
            else
            {
                charge = units * 20;
            }

            int totalWaterBill = charge + Meter_charge;

            return totalWaterBill;
        }
        static void Main(string[] args)
        {
            int totalWaterBill;
            Console.Write("Provide me the number of units consumed: ");

            if (!int.TryParse(Console.ReadLine(), out int unitsConsumed))
            {
                Console.WriteLine("You did not Provide a valid unit");
                return;
            }
            else
            {
                totalWaterBill = CalculateMeterBill(unitsConsumed);
            }



            Console.WriteLine("Your total bill is {0}", totalWaterBill);
        }
    }
}
