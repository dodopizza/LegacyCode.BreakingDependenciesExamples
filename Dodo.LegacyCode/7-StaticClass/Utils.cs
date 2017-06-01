using System;

namespace Dodo.LegacyCode
{
    public class Presenter
    {
        public void Show()
        {
            // ...

            var formattedDateTime = Utils.Format(DateTime.UtcNow);

            // ...
        }
    }

    public static class Utils
    {
        public static string Format(DateTime dateTime)
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