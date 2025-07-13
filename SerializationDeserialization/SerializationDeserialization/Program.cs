using System.Text.Json;

namespace SerializationDeserialization
{
    internal class Program
    {
        static string filePath = @"D:\practiceDotNet\Assignment\SerializationDeserialization\Person.json";
        static void Main(string[] args)
        {
            if (File.Exists(filePath))
            {
                //Deserialize
                string json = File.ReadAllText(filePath);
                List<Person> person = JsonSerializer.Deserialize<List<Person>>(json);

                Console.WriteLine("Deserialized person: ");
                foreach (var p in person)
                {
                    Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Email: {p.Email}");
                }
                Console.WriteLine($"Total Persons: {person.Count}");
            }

            else
            {
                //Serialize
                List<Person> person = new List<Person>
                {
                    new Person { Id = 1, Name= "Youbraj", Email = "youbraj@gmail.com" },
                    new Person { Id = 2, Name= "yash", Email = "yash@gmail.com" },
                    new Person { Id = 3, Name= "rohan", Email = "rohan@gmail.com" },
                    new Person { Id = 4, Name= "Sujal", Email = "sujal@gmail.com" },
                    new Person { Id = 5, Name= "manish", Email = "manish@gmail.com" }
                };

                string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("5 Person objects serialized to person.json");
            }

        }


    }
}