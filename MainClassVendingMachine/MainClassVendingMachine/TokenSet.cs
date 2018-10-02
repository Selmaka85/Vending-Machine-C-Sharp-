using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class TokenSet
    {
        // Fields
        private ArrayList set = new ArrayList();

        // Methods
        public void addToken(Token c)
        {
            this.set.Add(c);
        }

        public void addTokens(TokenSet other)
        {
            this.set.AddRange(other.set);
        }

        public double getValue()
        {
            double num = 0.0;
            foreach (Token Token in this.set)
            {
                num += Token.getValue();
            }
            return num;
        }

        public void removeAllTokens()
        {
            this.set.Clear();
        }
    }
}
