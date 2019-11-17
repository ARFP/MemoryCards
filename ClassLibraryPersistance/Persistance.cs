using ClassLibraryIPersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public class Persistance : IPersistanceTestScore, IPersistanceTrialsScore, IPersistanceUser, IPersistancesEtalonnages, IPersistanceResumeEtalonnageAllAge
    {
        string pathSave;

        public Persistance(string _pathSave)
        {
            pathSave = _pathSave;
        }

        sResumeEtalonnagesAllAge IPersistanceResumeEtalonnageAllAge.Read()
        {
            sResumeEtalonnagesAllAge resaa = new sResumeEtalonnagesAllAge();
            resaa.EtalonnageAllAges = new List<sResumeEtalonnageAllAge>();
            try
            {
                var sheet = ConnectionEtalonnage.Connect();
                resaa.TotalNumber = int.Parse(sheet.Cell("B1").Value.ToString());
                for (int i = 0; i < 8; i++)
                {
                    sResumeEtalonnageAllAge lreaa = new sResumeEtalonnageAllAge();
                    lreaa.AgeRange = sheet.Cell(3 + i, "A").Value.ToString();
                    lreaa.NumberPersoneTest = int.Parse(sheet.Cell(3 + i, "B").Value.ToString());
                    lreaa.AverageAge = double.Parse(sheet.Cell(3 + i, "C").Value.ToString());
                    lreaa.SDAge = double.Parse(sheet.Cell(3 + i, "D").Value.ToString());
                    resaa.EtalonnageAllAges.Add(lreaa);
                }
                return resaa;
            }
            catch(Exception e)
            {
                string a = e.Message;
                return default;
            }
        }

        sEtalonnages IPersistancesEtalonnages.Read(int _age)
        {
            int i = 0;
            sEtalonnages etalonnages = new sEtalonnages();
            etalonnages.Etalonnages = new List<sEtalonnage>();
            try
            {
                var sheet = ConnectionEtalonnage.Connect();
            if (_age < 30) { i = 3; }
                else if (_age < 40) { i = 11; }
                else if (_age < 50) { i = 19; }
                else if (_age < 60) { i = 27; }
                else if (_age < 70) { i = 35; }
                else { i = 43; }
                etalonnages.Name = sheet.Cell(i, "A").Value.ToString();
                for (int j = 0; j < 7; j++)
                {
                    sEtalonnage etalonnage = new sEtalonnage();
                    etalonnage.Trial = int.Parse(sheet.Cell(i + j, "B").Value.ToString());
                    etalonnage.AverageMove = double.Parse(sheet.Cell(i + j, "C").Value.ToString());
                    etalonnage.SDMove = double.Parse(sheet.Cell(i + j, "D").Value.ToString());
                    etalonnage.AverageRepeat = double.Parse(sheet.Cell(i + j, "E").Value.ToString());
                    etalonnage.SDRepeat = double.Parse(sheet.Cell(i + j, "F").Value.ToString());
                    etalonnage.AverageScore = double.Parse(sheet.Cell(i + j, "G").Value.ToString());
                    etalonnage.SDScore = double.Parse(sheet.Cell(i + j, "H").Value.ToString());
                    etalonnages.Etalonnages.Add(etalonnage);
                }
                return etalonnages;
            }
            catch(Exception e)
            {
                string a = e.Message;
                return default;
            }
        }

        bool IPersistancesEtalonnages.Write(sEtalonnages _sEtalonnages)
        {
            int i = 0;
            var sheet = ConnectionResult.Connect();
            try
            {
                foreach (sEtalonnage etalonnage in _sEtalonnages.Etalonnages)
                {
                    sheet.Cell(28 + i, "B").Value = etalonnage.Trial;
                    sheet.Cell(28 + i, "C").Value = etalonnage.AverageMove;
                    sheet.Cell(28 + i, "D").Value = etalonnage.SDMove;
                    sheet.Cell(28 + i, "E").Value = etalonnage.AverageRepeat;
                    sheet.Cell(28 + i, "F").Value = etalonnage.SDRepeat;
                    sheet.Cell(28 + i, "G").Value = etalonnage.AverageScore;
                    sheet.Cell(28 + i, "H").Value = etalonnage.SDScore;
                    i++;
                }
                return ConnectionResult.Save(pathSave);
            }
            catch(Exception e)
            {
                string a = e.Message;
                return false;
            }

        }

        bool IPersistanceTestScore.Write(sTestScore _score)
        {
            try
            {
                var sheet = ConnectionResult.Connect();
                sheet.Cell("B20").Value = _score.AverageMove;
                sheet.Cell("B21").Value = _score.AverageRepeat;
                sheet.Cell("B22").Value = _score.AverageScore;
                return ConnectionResult.Save(pathSave);
            }
            catch(Exception e)
            {
                string a = e.Message;
                return false;
            }
        }

        bool IPersistanceTrialsScore.Write(sTrialsScore _score)
        {
            int i = 0;
            try
            {
                var sheet = ConnectionResult.Connect();
                foreach(sTrialScore t in _score.Ltrials)
                {
                    sheet.Cell(13 + i, "A").Value = t.TrialNumber;
                    sheet.Cell(13 + i, "B").Value = t.TypeTest;
                    sheet.Cell(13 + i, "C").Value = t.NumberCards;
                    sheet.Cell(13 + i, "D").Value = t.Sound ? "Oui" : "Non";
                    sheet.Cell(13 + i, "E").Value = t.Shuffle ? "Oui" : "Non";
                    sheet.Cell(13 + i, "F").Value = t.Move;
                    sheet.Cell(13 + i, "G").Value = t.Repeat;
                    sheet.Cell(13 + i, "H").Value = t.ScoreTrial;
                    i++;
                }
                return ConnectionResult.Save(pathSave);
            }
            catch(Exception e)
            {
                string a = e.Message;
                return false;
            }
        }

        bool IPersistanceUser.Write(sUser _user)
        {
            try
            {
                var sheet = ConnectionResult.Connect();
                sheet.Cell("B3").Value = _user.LastName + " " + _user.FirstName;
                sheet.Cell("B4").Value = _user.Genre;
                sheet.Cell("B5").Value = _user.Age;
                sheet.Cell("B6").Value = _user.DateOfTheDay.Date;
                sheet.Cell("B7").Value = _user.DateOfTheDay.Hour + " : " + _user.DateOfTheDay.Minute + " : " + _user.DateOfTheDay.Second;        
                return ConnectionResult.Save(pathSave);
            }
            catch(Exception e)
            {
                string a = e.Message;
                return false;
            }
        }
    }
}
