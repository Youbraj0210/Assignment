namespace TrafficSignalEnum
{
    enum TrafficLight { RED, YELLOW, GREEN }


    internal class Program
    {
        public static void TrafficActions(TrafficLight light)
        {
            switch (light)
            {
                case (TrafficLight.RED): Console.WriteLine("STOP!"); break;
                case TrafficLight.YELLOW: Console.WriteLine("READY!"); break;
                case TrafficLight.GREEN: Console.WriteLine("GO!"); break;
                default: Console.WriteLine("invalid input!"); break;
            }
        }

        static void Main(string[] args)
        {
            TrafficActions(TrafficLight.RED);
            TrafficActions(TrafficLight.YELLOW);
            TrafficActions(TrafficLight.GREEN);
        }
    }
}
