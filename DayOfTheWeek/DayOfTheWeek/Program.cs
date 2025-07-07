namespace DayOfTheWeek
{
    enum DaysOfWeek { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY }

    internal class Program
    {

        public static void Week(int num)
        {
            DaysOfWeek day = DaysOfWeek.SUNDAY;
            switch (num)
            {
                case 1: day = DaysOfWeek.MONDAY; break;
                case 2: day = DaysOfWeek.TUESDAY; break;
                case 3: day = DaysOfWeek.WEDNESDAY; break;
                case 4: day = DaysOfWeek.THURSDAY; break;
                case 5: day = DaysOfWeek.FRIDAY; break;
                case 6: day = DaysOfWeek.SATURDAY; break;
                case 7: day = DaysOfWeek.SUNDAY; break;
                default: Console.WriteLine("wrong output!"); break;
            }
            Console.WriteLine(day);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-7): ");
            Week(int.Parse(Console.ReadLine()));
        }
    }
}
