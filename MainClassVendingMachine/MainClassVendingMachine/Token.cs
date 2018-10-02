using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class Token
    {
        // Fields
        private string name;
        private double value;

        // Methods
        public Token(double aValue, string aName)
        {
            this.value = aValue;
            this.name = aName;
        }

        public string getName() =>
            this.name;

        public double getValue() =>
            this.value;

        public override string ToString() =>
            (this.name + " £Pounds Value  " + this.value);
    }
}
