using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dodo.LegacyCode.ExtractAndOverride;
using NUnit.Framework;

namespace Tests
{
    public class WhenPrintReceipt
    {
        [Test]
        public void ShouldPrintFooterLine()
        {
            var terminal = new TerminalFake();
            var printer = new TestablePrinter(terminal);

            printer.PrintReceipt(new ShoppingCart());

            Assert.That(printer.LastPrinterLine, Is.EqualTo("----Footer---"));
            Assert.That(terminal.LastPrinterLine, Is.EqualTo("----Footer---"));
        }
    }


    public class TestablePrinter : Printer
    {
        private readonly TerminalFake terminal;

        public TestablePrinter()
        {
            Lines = new List<string>();
            LastPrinterLine = "default";
            terminal = new TerminalFake();
        }

        public TestablePrinter(TerminalFake terminal)
        {
            this.terminal = terminal;
        }

        protected override Terminal CreateTerminal()
        {
            return terminal;
        }

        protected override void WriteLine(string line)
        {
            Lines.Add(line);
            LastPrinterLine = line;
        }

        public List<string> Lines { get; set; }

        public string LastPrinterLine { get; private set; }
    }

    public class TerminalFake : Terminal
    {
        public override void PrintLine(string message)
        {
            LastPrinterLine = message;
        }

        public string LastPrinterLine { get; private set; }
    }
}