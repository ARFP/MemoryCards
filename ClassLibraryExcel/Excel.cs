using ClassLibraryMemento;
using ClassLibraryViewModel;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExcel
{
    public static class Excel
    {
        public static void WriteInExecel(ViewModelTest _vmTest)
        {
            int i = 0;
            var workbook = new XLWorkbook(ConfigurationManager.AppSettings["ModelResultBen"]);
            var worksheet = workbook.Worksheet("Resultat");
            worksheet.Cell("B3").Value = _vmTest.User.LastName + " " + _vmTest.User.FirstName;
            worksheet.Cell("B4").Value = _vmTest.User.Genre;
            worksheet.Cell("B5").Value = _vmTest.User.Age;
            worksheet.Cell("B6").Value = _vmTest.User.DateOfTheDay.Date;
            worksheet.Cell("B7").Value = _vmTest.User.DateOfTheDay.Hour + " : " + _vmTest.User.DateOfTheDay.Minute + " : " + _vmTest.User.DateOfTheDay.Second;
            foreach (TrialScore ts in _vmTest.TestScore.TrialsScore)
            {
                worksheet.Cell(13 + i, "A").Value = ts.TrialNumber;
                worksheet.Cell(13 + i, "B").Value = ts.TypeTest;
                worksheet.Cell(13 + i, "C").Value = ts.NumberCards;
                worksheet.Cell(13 + i, "D").Value = ts.Sound ? "Oui" : "Non";
                worksheet.Cell(13 + i, "E").Value = ts.Shuffle ? "Oui" : "Non";
                worksheet.Cell(13 + i, "F").Value = ts.Move;
                worksheet.Cell(13 + i, "G").Value = ts.Repeat;
                worksheet.Cell(13 + i, "H").Value = ts.ScoreTrial;
                i++;
            }
            TrialEtalonnage te = ReadEtalonnage(_vmTest.User.Age);
            worksheet.Cell("A28").Value = te.Name;
            i = 0;
            foreach (OneTrialEtalonnage ote in te.TrialEtalonnages)
            {
                worksheet.Cell(28 + i, "B").Value = ote.Trial;
                worksheet.Cell(28 + i, "C").Value = double.Parse(ote.AverageMove);
                worksheet.Cell(28 + i, "D").Value = double.Parse(ote.SDMove);
                worksheet.Cell(28 + i, "E").Value = double.Parse(ote.AverageRepeat);
                worksheet.Cell(28 + i, "F").Value = double.Parse(ote.SDRepeat);
                worksheet.Cell(28 + i, "G").Value = double.Parse(ote.AverageScore);
                worksheet.Cell(28 + i, "H").Value = double.Parse(ote.SDScore);
                i++;
            }
            worksheet.Cell("B20").Value = _vmTest.TestScore.AverageMove;
            worksheet.Cell("B21").Value = _vmTest.TestScore.AverageRepeat;
            worksheet.Cell("B22").Value = _vmTest.TestScore.AverageScore;       
            workbook.SaveAs(ConfigurationManager.AppSettings["SaveExcelBen"] + _vmTest.User.FirstName + _vmTest.User.LastName + ".xlsx");
        }

        public static TrialEtalonnage ReadEtalonnage(int _age)
        {
            int i = 0;
            TrialEtalonnage trialEtalonnage = new TrialEtalonnage();
            trialEtalonnage.TrialEtalonnages = new List<OneTrialEtalonnage>();
            var workbook = new XLWorkbook(ConfigurationManager.AppSettings["EtalonnageResultBen"]);
            var worksheet = workbook.Worksheet("Etalonnage");
            if (_age < 30) { i = 3; }
            else if (_age < 40) { i = 11; }
            else if (_age < 50) { i = 19; }
            else if (_age < 60) { i = 27; }
            else if (_age < 70) { i = 35; }
            else { i = 43; }
            trialEtalonnage.Name = worksheet.Cell(i, "A").Value.ToString();
            for (int j = 0; j < 7; j++)
            {
                OneTrialEtalonnage oneTrialEtalonnage = new OneTrialEtalonnage();
                oneTrialEtalonnage.Trial = worksheet.Cell(i + j, "B").Value.ToString();
                oneTrialEtalonnage.AverageMove = worksheet.Cell(i + j, "C").Value.ToString();
                oneTrialEtalonnage.SDMove = worksheet.Cell(i + j, "D").Value.ToString();
                oneTrialEtalonnage.AverageRepeat = worksheet.Cell(i + j, "E").Value.ToString();
                oneTrialEtalonnage.SDRepeat = worksheet.Cell(i + j, "F").Value.ToString();
                oneTrialEtalonnage.AverageScore = worksheet.Cell(i + j, "G").Value.ToString();
                oneTrialEtalonnage.SDScore = worksheet.Cell(i + j, "H").Value.ToString();
                trialEtalonnage.TrialEtalonnages.Add(oneTrialEtalonnage);
            }
            return trialEtalonnage;
        }

        public static RangeAgeEtalonnage AllRangeEtalonnage()
        {
            RangeAgeEtalonnage rae = new RangeAgeEtalonnage();
            rae.LOrae = new List<OneRangeAgeEtalonnage>();
            var workbook = new XLWorkbook(ConfigurationManager.AppSettings["EtalonnageResultBen"]);
            var worksheet = workbook.Worksheet("ResumeAll");
            rae.TotalPersone = worksheet.Cell("B1").Value.ToString();
            for( int i = 0; i < 8; i++)
            {
                OneRangeAgeEtalonnage orae = new OneRangeAgeEtalonnage();
                orae.AgeRange = worksheet.Cell(3 + i, "A").Value.ToString();
                orae.NumberPersoneTest = worksheet.Cell(3 + i, "B").Value.ToString();
                orae.AverageAge = worksheet.Cell(3 + i, "C").Value.ToString();
                orae.SDAge = worksheet.Cell(3 + i, "D").Value.ToString();
                rae.LOrae.Add(orae);
            }
            return rae;
        }
    }
}
