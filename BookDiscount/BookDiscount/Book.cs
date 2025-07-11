using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDiscount
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestSeller { get; set; }
        public double DiscountedPrice { get; set; }

        public Book(string bookTitle, string bookAuthor, double bookPrice, bool bookBestSeller)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Price = bookPrice;
            IsBestSeller = bookBestSeller;

        }

        public void calculateDiscountedPrice()
        {
            double bestSellerDiscount = 0;
            double priceDiscount = 0;

            if (IsBestSeller)
            {
                bestSellerDiscount = Price * 0.1;
            }

            if (Price > 500)
            {
                priceDiscount = Price * 0.05;
            }

            DiscountedPrice = Price - bestSellerDiscount - priceDiscount;
        }

        public void printDiscountedPrice()
        {
            Console.WriteLine($"Discounted price of \"{Title}\": {DiscountedPrice}");
        }
    }
}
