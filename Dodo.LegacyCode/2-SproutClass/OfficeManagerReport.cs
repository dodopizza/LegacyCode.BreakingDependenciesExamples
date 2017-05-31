using System.Text;

namespace Dodo.LegacyCode
{
    public class OfficeManagerReport
    {
        public string htmlStatement(OfficeManager officeManager)
        {
            var result = new StringBuilder();
            result.AppendLine("<table>");
            var header = $"<h1>Office Manager Report for <em>{officeManager.Name}</em></h1>";
            result.AppendLine(header);

            foreach (var item in officeManager.Items)
            {
                result.AppendLine($"<p>Item - {item}</p>");
            }

            var footer = "<p>----------2017 (c)----------</p>";
            result.AppendLine(footer);
            result.AppendLine("</table>");

            return result.ToString();
        }
    }
}