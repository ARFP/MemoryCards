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
        #region Propriétées
        private static XLWorkbook book;
        private static IXLWorksheet sheet;
        #endregion

        #region
        /// <summary>
        /// Connection au fichier excel, des etalonnages
        /// </summary>
        /// <returns>L'instance de connection du fichier</returns>
        public static IXLWorksheet Connect()
        {
            if (sheet is null)
            {
                book = new XLWorkbook(ConfigurationManager.AppSettings["EtalonnageCrm"]);
                sheet = book.Worksheet("Etalonnage");
            }
            return sheet;
        }
        #endregion
    }
}
