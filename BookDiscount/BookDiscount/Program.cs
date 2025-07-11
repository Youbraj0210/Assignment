namespace BookDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Psychology of Money", "Morgan", 900, false);
            book1.calculateDiscountedPrice();
            book1.printDiscountedPrice();

            Book book2 = new Book("Do Nothing", "Rushabh", 690, true);
            book2.calculateDiscountedPrice();
            book2.printDiscountedPrice();
        }
    }
}