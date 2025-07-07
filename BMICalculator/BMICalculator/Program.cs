namespace BMICalculator
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public double Height { get; set; } = 5;
        public double Weight { get; set; } = 50;


        public Person(int id, string name,int age, double height,double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public Person(int id, string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public double BMI()
        {
            double bmi = (Weight / (Height * Height * 0.3048 * 0.3048)) ;
            return bmi;
        }

        public void Bodytype()
        {
            if (BMI() < 18.5) Console.WriteLine("Underweight");
            if (BMI() >= 18.5 && BMI() <= 24.5) Console.WriteLine("Normal");
            if (BMI() >= 25) Console.WriteLine("Overweight");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(101,"youbraj",21);
            Person p2 = new Person(102, "Rohan", 21, 6.2, 105);

            p1.Bodytype();
            p2.Bodytype();
        }
    }
}
