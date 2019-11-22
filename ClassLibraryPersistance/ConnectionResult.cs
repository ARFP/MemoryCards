using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public static class ConnectionResult
    {
        //Chemin sauvegarde des donées--------------------------------------------------------------------
        // System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static XLWorkbook book;
        private static IXLWorksheet sheet;

        public static IXLWorksheet Connect()
        {
            if (sheet is null)
            {
                book = new XLWorkbook(ConfigurationManager.AppSettings["ModelReusltCrm"]);
                sheet = book.Worksheet("Resultat");
            }
            return sheet;
        }

        public static bool Save(string _path)
        {
            try
            {
                book.SaveAs(ConfigurationManager.AppSettings["SaveExcelCrm"] + _path + ".xlsx");
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
