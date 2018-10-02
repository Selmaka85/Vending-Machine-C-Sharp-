using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    internal class MainClassVendingMachine
    {
        // Methods
        private static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();
            new MachineMenu().run(machine);
        }
    }

}
