namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John Cena");
            Student student2 = new Student("Randy Orton", 78);
            Student student3 = new Student("Cody Rhodes", 99, 'A');

            Student.AssignGrade(student1);
            Student.AssignGrade(student2);
            Student.AssignGrade(student3);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
