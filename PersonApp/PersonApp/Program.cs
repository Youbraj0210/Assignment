namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(10,"youbraj",21);
            person.Bodytype();

            Person person1 = new Person(101, "Rohan", 21, 6, 90);
            person1.Bodytype();

            ChainingDemo ch = new ChainingDemo();
        }
    }
}
