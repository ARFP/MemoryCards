using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public static class ConnectionEtalonnage
    {
        private static XLWorkbook book;
        private static IXLWorksheet sheet;

        public static IXLWorksheet Connect()
        {
            if (sheet is null)
            {
                book = new XLWorkbook(ConfigurationManager.AppSettings["EtalonnageResultBen"]);
                sheet = book.Worksheet("Etalonnage");
            }
            return sheet;
        }
    }
}
