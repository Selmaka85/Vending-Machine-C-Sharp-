using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassVendingMachine
{
    public class MachineMenu
    {
        // Fields
        private static Token[] Tokens = new Token[] { new Token(0.05, "Penny"), new Token(0.1, "Penny"), new Token(0.25, "Penny"), new Token(1.0, "Pound"),new Token(2.0, "Pounds"), new Token(5.0, "Pounds") };

        public Product product { get; private set; }

        // Methods
        private object getChoice(object[] choices)
        {
            while (true)
            {
                char ch = 'A';
                foreach (object obj2 in choices)
                {
                    Console.Out.WriteLine(ch + ") " + obj2.ToString());
                    ch = (char)(ch + '\x0001');
                }
                int index = Console.ReadLine().ToUpper().ToUpper()[0] - 'A';
                if ((0 <= index) && (index < choices.Length))
                {
                    return choices[index];
                }
                Console.Out.WriteLine("Please select a product from the displayed products ");
            }
        }

        public void run(VendingMachine machine)
        {
            bool flag = true;
            while (flag)
            {
                Console.Out.WriteLine("A)Show products  B)Insert Token  C)Buy  D)Add product  E)Remove Tokens  F)Quit");
                string str = Console.ReadLine().ToUpper();
                if (str.Equals("A"))
                {
                    foreach (Product product in machine.getProductTypes())
                    {
                        Console.Out.WriteLine("This is:" + product.ToString());
                    }
                }
                else if (str.Equals("B"))
                {
                    machine.addToken((Token)this.getChoice(Tokens));
                    Console.Out.WriteLine("Inserted Token: " + machine.currentTokens.getValue());
                }
                else if (str.Equals("E"))
                {
                    Console.Out.WriteLine("Removed: £" + machine.removeMoney());
                }
                else if (str.Equals("C"))
                {
                    try
                    {
                        product = (Product)this.getChoice(machine.getProductTypes());
                        Console.Out.WriteLine("You chosen option: " + product.ToString());
                        machine.buyProduct(product);
                        Console.Out.WriteLine("Purchased product: " + product.ToString());
                    }
                    catch (VendingMachineException exception)
                    {
                        Console.Out.WriteLine(exception.Message);
                    }
                }
                else if (str.Equals("D"))
                {
                    double num;
                    int num2;
                    Console.Out.WriteLine("Description of product:");
                    string aDescription = Console.ReadLine();
                    Console.Out.WriteLine("Product price:");
                    if (!double.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Invalid number entered. Please enter number in format: #.#");
                    }
                    Console.Out.WriteLine("Quantity of products:");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid number entered. Please enter an interger number");
                    }
                    machine.addProduct(new Product(aDescription, num), num2);
                }
                else if (str.Equals("F"))
                {
                    flag = false;
                }
            }
        }
    }
}
