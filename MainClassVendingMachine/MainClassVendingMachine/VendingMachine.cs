using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class VendingMachine
    {
        // Fields
        public TokenSet Tokens = new TokenSet();
        public TokenSet currentTokens = new TokenSet();
        private ArrayList products = new ArrayList();

        // Methods
        public void addToken(Token c)
        {
            this.currentTokens.addToken(c);
        }

       public void addProduct(Product p, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.products.Add(p);
            }
        }

        public void buyProduct(Product p)
        {
            for (int i = 0; i < this.products.Count; i++)
            {
                Product product = (Product)this.products[i];
                if (product.Equals(p))
                {
                    double num2 = this.currentTokens.getValue();
                    if (p.getPrice() > num2)
                    {
                        throw new VendingMachineException("Insufficient tokens! ");
                    }
                    this.products.RemoveAt(i);
                    this.Tokens.addTokens(this.currentTokens);
                    this.currentTokens.removeAllTokens();
                    return;
                }
            }
            throw new VendingMachineException("No product available!");
        }

        public Product[] getProductTypes()
        {
            ArrayList list = new ArrayList();
            foreach (Product product in this.products)
            {
                if (!list.Contains(product))
                {
                    list.Add(product);
                }
            }
            Product[] productArray = new Product[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                productArray[i] = (Product)list[i];
            }
            return productArray;
        }

        public double removeMoney()
        {
            
            double num = this.Tokens.getValue();
            this.Tokens.removeAllTokens();

            return num;
        }
    }
}
