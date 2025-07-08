using System.Collections;

namespace ShoppingCartLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", 60000.00),
                new Product(2, "Smartphone", 25000.00),
                new Product(3, "Headphones", 3000.00),
                new Product(4, "Smartwatch", 5000.00),
                new Product(5, "Bluetooth Speaker", 1500.00),
                new Product(6, "Tablet", 18000.00),
                new Product(7, "External Hard Drive", 4500.00),
                new Product(8, "Gaming Mouse", 1200.00),
                new Product(9, "Mechanical Keyboard", 3500.00),
                new Product(10, "Webcam", 2200.00)
            };


            List<LineItem> lineItems = new List<LineItem>();

            lineItems.Add(new LineItem(101, 5, products[6]));
            lineItems.Add(new LineItem(102, 2, products[4]));
            lineItems.Add(new LineItem(103, 1, products[1]));
            lineItems.Add(new LineItem(104, 1, products[0]));

            List<Order> listOfOrders = new List<Order>();

            Order order1 = new Order(001, DateTime.Now, lineItems);

            listOfOrders.Add(order1);

            Customer customer = new Customer(1001,"Youbraj",listOfOrders);

            customer.DisplayBill();





        }
    }
}
