using System;

namespace Dodo.LegacyCode
{
    public class Presenter
    {
        public void Show()
        {
            // ...

            var formattedDateTime = new Utils().NewFormat(DateTime.UtcNow);

            // ...
        }
    }

    public class Utils
    {
        public string NewFormat(DateTime dateTime)
        {
            return $"DateTime - {dateTime.ToLongTimeString()}";
        }

        public static void ReFormat()
        {
            // ...
        }

        public static void AnotherFormat()
        {
            // ...
        }
    }
}