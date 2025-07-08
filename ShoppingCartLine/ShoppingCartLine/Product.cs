using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLine
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice {  get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountedPrice = CalculateDiscountedPrice();
        }

        public double CalculateDiscountedPrice()
        {
            DiscountedPrice = Price - (Price * 0.1);
            return DiscountedPrice;
        }
    }
}
