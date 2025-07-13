namespace AbstractClassAndInterface
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Eat() => Console.WriteLine("Animal is eating.");
    }

    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Dog barks.");
    }

    interface IMovable
    {
        void Move();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Bird : IMovable, IFlyable
    {
        public void Move() => Console.WriteLine("Bird moves on land.");
        public void Fly() => Console.WriteLine("Bird flies in the sky.");
    }

    interface IBase
    {
        void Show();
    }

    interface IDerived1 : IBase
    {
        new void Show();
    }

    interface IDerived2 : IBase
    {
        new void Show();
    }

    class Diamond : IDerived1, IDerived2
    {

        void IDerived1.Show()
        {
            Console.WriteLine("IDerived1's Show method");
        }

        void IDerived2.Show()
        {
            Console.WriteLine("IDerived2's Show method");
        }

        public void Show()
        {
            Console.WriteLine("Diamond's own Show method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Class ===");
            Animal dog = new Dog();
            dog.MakeSound();
            dog.Eat();

            Console.WriteLine("\n=== Interfaces ===");
            Bird bird = new Bird();
            bird.Move();
            bird.Fly();

            Console.WriteLine("\n=== Diamond Problem and Solution ===");
            Diamond diamond = new Diamond();

            diamond.Show();

            IDerived1 d1 = diamond;
            d1.Show(); 

            IDerived2 d2 = diamond;
            d2.Show();
        }
    }
}