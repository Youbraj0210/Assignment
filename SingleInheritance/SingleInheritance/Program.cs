namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Name = "Rupa";
            parent.Height = 5.2;
            parent.Id = 1;

            parent.ToString();

            Child child = new Child();
            child.Height = 5.8;
            child.Id = 2;
            child.ToString();

            Parent parent2 = new Parent(101, "John", 5.3);
            parent2.ToString();

            Child child2 = new Child(110, "Roman", 6.3, "LTCE");
            child2.ToString();
        }
    }
}
