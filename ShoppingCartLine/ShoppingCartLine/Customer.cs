using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLine
{
    internal class Customer
    {
        public int CustId {  get; set; }
        public string CustName { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, List<Order> orders)
        {
            CustId = id;
            CustName = name;
            Orders = orders;
        }

        public void DisplayBill()
        {
            double price = 0;
            Console.WriteLine("----------BILL-----------");
            foreach (Order order in Orders)
            {
                price += order.CalculateOrderPrice();
                foreach(LineItem item in order.Items)
                {
                    Console.WriteLine($"{item.Id} | {item.Quantity} * {item.CalculateLineItemCost()}");
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Total Bill: "+ price);
        }
    }
}
