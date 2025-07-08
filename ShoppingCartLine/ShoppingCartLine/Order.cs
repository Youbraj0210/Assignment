using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLine
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public List<LineItem> Items { get; set; }

        public Order(int id, DateTime date, List<LineItem> items)
        {
            Id = id;
            this.date = date;
            Items = items;
        }

        public double CalculateOrderPrice()
        {
            double price = 0;
            foreach (LineItem item in Items)
            {
                price += item.CalculateLineItemCost();
            }

            return price;
        }
    }
}
