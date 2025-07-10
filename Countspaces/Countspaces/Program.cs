namespace Countspaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello How are you?";
            int count = 0;

            foreach(char c in str)
            {
                if(c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("Total space: "+count);
        }
    }
}
