namespace PocChainingBoxUnbox
{
    internal class SingleClass
    {
        public SingleClass(int n) : this("s")
        {
            Console.WriteLine("in constructor 1");
        }

        public SingleClass() : this(100)
        {
            Console.WriteLine("in constructor 2");
        }

        public SingleClass(string str)
        {
            Console.WriteLine("in constrctor 3");
        }
    }

    internal class Parent
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "Youbraj";
        public double Height { get; set; } = 5.5;

        public Parent()
        {
            Console.WriteLine("this is the constructor of the parent class!");
        }

        public Parent(int id, string name, double height)
        {
            Id = id;
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            string str = $"id: {this.Id} name: {this.Name} height: {this.Height}";
            Console.WriteLine(str);
            return str;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleClass singleClass = new SingleClass();
            SingleClass singleClass1 = new SingleClass(100);

            Parent parent = new Parent();
            parent.Name = "Rupa";
            parent.Height = 5.2;
            parent.Id = 1;

            Parent parent2 = new Parent(101, "John", 5.3);
            parent2.ToString();

            string str = "sss";
            Object obj = str;

            if (str is int)
            {
                Console.WriteLine("the string is of type int");
            }
            else
            {
                Console.WriteLine("this string is not of type int");
            }

            Object[] myObj = new Object[3];
            myObj[0] = 10;
            myObj[1] = "str";
            myObj[2] = true;

            string s = myObj[0] as string;
            Console.WriteLine(s);

            string st = myObj[1] as string;
            Console.WriteLine(st);

            int t1;
            var t2 = 10;
            var t3 = "hello";
            var t4 = 'c';

            Console.WriteLine("------------DEMO-------------");
            Console.WriteLine("variable with var keywords: {0} {1} {2}", t2, t3, t4);
        }
    }
}
