using System;

namespace Dodo.LegacyCode.ExtractAndOverride
{
    public class Printer
    {
        public void PrintReceipt(ShoppingCart shoppingCart)
        {
            WriteLine("-----Receipt-------");
            WriteLine("-------------------");

            var terminal = CreateTerminal();
            terminal.PrintLine("<<Shopping cart items>>");

            WriteLine("-----Total--------");
            WriteLine($"----- {shoppingCart.TotalPrice} ---------");
        }

        protected virtual Terminal CreateTerminal()
        {
            return new Terminal();
        }

        protected virtual void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}