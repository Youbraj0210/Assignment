using System.Collections;

namespace DynamicArrayVsGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== ArrayList (Non-Generic) ===");

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Alice");
            arrayList.Add(100);           
            arrayList.Add(3.14);          
            arrayList.Add(true);          

            Console.WriteLine("Items in ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ({item.GetType().Name})");
            }

            Console.WriteLine($"Item at index 2: {arrayList[2]}");


            Console.WriteLine("\n=== List<T> (Generic) ===");

            List<string> nameList = new List<string>();
            nameList.Add("Bob");
            nameList.Add("Charlie");
            nameList.Add("David");

            Console.WriteLine("Items in List<string>:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Item at index 1: {nameList[1]}");


        }
    }
}