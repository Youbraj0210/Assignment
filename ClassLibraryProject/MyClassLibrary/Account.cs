namespace MyClassLibrary
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public Account(string accountNumber, string name, int balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Name: {Name} AccNo: {AccountNumber} Balance: {Balance}";
        }
    }
}
