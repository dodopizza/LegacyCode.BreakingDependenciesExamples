using System;

namespace Dodo.LegacyCode.ExtractAndOverride
{
    public class Terminal
    {
        public virtual void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}