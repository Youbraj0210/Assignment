namespace StudentGradingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Youbraj Singh";
            int roll = 67;
            int[] marks = { 90, 97, 88, 94, 92 };
            Student student = new Student(name,roll,marks);

            student.ReportCard();
        }
    }
}
