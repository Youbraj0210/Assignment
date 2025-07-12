namespace ClassVsStruct
{
    public class StudentClass
    {
        public string Name;
        public int Age;

        public StudentClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public struct StudentStruct
    {
        public string Name;
        public int Age;

        public StudentStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }


    class Program
    {
        static void Main()
        {
            StudentClass classStudent1 = new StudentClass("Alice", 20);
            StudentClass classStudent2 = classStudent1; 


            classStudent2.Name = "Bob";

            Console.WriteLine("Class Student1 Name: " + classStudent1.Name);  
            Console.WriteLine("Class Student2 Name: " + classStudent2.Name);  

            Console.WriteLine();

            StudentStruct structStudent1 = new StudentStruct("John", 21);
            StudentStruct structStudent2 = structStudent1; 

            structStudent2.Name = "David";

            Console.WriteLine("Struct Student1 Name: " + structStudent1.Name); 
            Console.WriteLine("Struct Student2 Name: " + structStudent2.Name); 
        }
    }
}