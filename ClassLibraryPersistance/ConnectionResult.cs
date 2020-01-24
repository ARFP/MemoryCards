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
        #region Propriétées
        private static XLWorkbook book;
        private static IXLWorksheet sheet;
        #endregion

        #region Méthodes
        /// <summary>
        /// Connection au fichier excel, de sauvegarde des données du test
        /// </summary>
        /// <returns>L'instance de connection du fichier</returns>
        public static IXLWorksheet Connect()
        {
            if (sheet is null)
            {
                book = new XLWorkbook(ConfigurationManager.AppSettings["ModelReusltCrm"]);
                sheet = book.Worksheet("Resultat");
            }
            return sheet;
        }

        /// <summary>
        /// Sauvegarde le fichier de résultat au format "xlsx"
        /// </summary>
        /// <param name="_name">Nom du fichier a sauvegarder</param>
        /// <returns>Si la sauvegarde du fichier a réussi</returns>
        public static bool Save(string _name)
        {
            try
            {
                book.SaveAs(ConfigurationManager.AppSettings["SaveExcelCrm"] + _name + ".xlsx");
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
