using System;

namespace Dodo.LegacyCode.ExtractAndOverride
{
    public class Printer
    {
        public void PrintReceipt(ShoppingCart shoppingCart)
        {
            Console.WriteLine("-----Receipt-------");
            Console.WriteLine("-------------------");

            var terminal = new Terminal();
            terminal.PrintLine("<<Shopping cart items>>");

            Console.WriteLine("-----Total--------");
            Console.WriteLine($"----- {shoppingCart.TotalPrice} ---------");
        }
    }
}