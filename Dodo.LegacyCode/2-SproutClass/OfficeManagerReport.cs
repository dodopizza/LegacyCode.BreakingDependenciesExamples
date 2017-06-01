using System.Collections.Generic;
using System.Text;

namespace Dodo.LegacyCode
{
    public interface IOfficeManagerReportGenerator
    {
        string Generate(OfficeManager officeManager);
    }
    
    public class OfficeManagerReportFooterGenerator : IOfficeManagerReportGenerator
    {
        public string Generate(OfficeManager officeManager)
        {
            return "";
        }
    }

    public class OfficeManagerReportHeader : IOfficeManagerReportGenerator
    {
        public string Generate(OfficeManager officeManager)
        {
            return $"<h1>Office Manager Report for <b>{officeManager.Name}</b></h1>";
        }
    }

    public class OfficeManagerReport
    {
        public string htmlStatement(OfficeManager officeManager)
        {
            var records = GetDatabaseRecordsFor(officeManager);

            var result = new StringBuilder();
            result.AppendLine("<table>");
            
            var header = new OfficeManagerReportHeader().Generate(officeManager);
            
            result.AppendLine(header);

            foreach (var record in records)
            {
                result.AppendLine($"<p>Record - {record} - </p>");
            }

            var footer = "<p>----------2017 (c)----------</p>";
            result.AppendLine(footer);
            result.AppendLine("</table>");

            return result.ToString();
        }

        private IEnumerable<string> GetDatabaseRecordsFor(OfficeManager officeManager)
        {
            // some complicated DB call to get records
            return new List<string>();
        }
    }
}