namespace StringPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string str)
        {

            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            if(reversed == str)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("is plaindrome: "+ IsPalindrome("hello"));
        }
    }
}
