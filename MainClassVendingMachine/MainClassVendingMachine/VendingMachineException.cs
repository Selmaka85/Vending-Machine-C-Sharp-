using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class VendingMachineException : Exception
    {
        // Methods
        public VendingMachineException(string reason) : base(reason)
        {
        }
    }
}
