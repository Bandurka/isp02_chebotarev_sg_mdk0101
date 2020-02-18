using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Product
    {
        private string title { get; set; }
        private int quantity { get; set; }
        private int price { get; set; }
        private double shelfLife { get; set; }

        public Product(string productTitle, int productQuantity, int productPrice, double productShelfLife)
        {
            title = productTitle;
            quantity = productQuantity;
            price = productPrice;
            shelfLife = productShelfLife;
        }

        public override string ToString()
        {
            return "Product: " + title + " " + quantity + " " + price + " " + shelfLife;
        }
    }
}
