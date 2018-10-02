using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class Product
    {
        // Fields
        private string description;
        private double price;

        // Methods
        public Product(string aDescription, double aPrice)
        {
            this.description = aDescription;
            this.price = aPrice;
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            Product product = (Product)other;
            return (this.description.Equals(product.description) && (this.price == product.price));
        }

        public string getDescription() =>
            this.description;

        public double getPrice() =>
            this.price;

        public override string ToString() =>
            (this.description + " £" + this.price);
    }
}
