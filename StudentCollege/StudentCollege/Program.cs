namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 1,Address = "Uran",Name = "Youbraj",DOB = new DateTime(2003, 10, 2),Branch = "Computer Science"
            };
            student.DisplayStudentInfo();

            Console.WriteLine();
            // Professor
            Proffessor professor = new Proffessor
            {
                Id = 101,Name = "Sameera mam",Address = "Faculty Quarters",DOB = new DateTime(1986, 3, 15),Designation = ".Net Professor",YearsOfExperience = 10
            };
            professor.DisplayProfessorInfo();
        }
    }
}