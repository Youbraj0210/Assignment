namespace StudentEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Enter Roll number: ");
            int roll = int.Parse(Console.ReadLine());
            s.RollNo = roll;

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            s.Name = name;

            Console.WriteLine("Enter CGPA: ");
            double cgpa = double.Parse(Console.ReadLine());
            s.Gpa = cgpa;

            Console.WriteLine("\nStudent Details- ");
            Console.WriteLine(s);
        }
    }
}