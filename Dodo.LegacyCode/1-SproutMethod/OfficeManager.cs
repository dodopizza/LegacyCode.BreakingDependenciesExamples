using System.Collections.Generic;

namespace Dodo.LegacyCode
{
    public class OfficeManager
    {
        public string Name { get; private set; }
        public IEnumerable<string> Items { get; private set; }
    }
}