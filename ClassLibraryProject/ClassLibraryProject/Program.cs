using MyClassLibrary;

namespace ClassLibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* steps to create class library:
             * create new project of type class library
             * add the project reference in the main project
             * and also add using namespace of the class library in the man project to use the classes 
             */
            Account account = new Account("HDFC123456" , "Youbraj" ,100000);
            Console.WriteLine(account.ToString());
        }
    }
}
