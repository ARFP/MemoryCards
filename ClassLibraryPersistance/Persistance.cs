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
        #region Méthodes
        #region Etalonnages
        /// <summary>
        /// Récupères les données des l'étalonnages tout ages dans
        /// le fichier de données
        /// </summary>
        /// <returns>Structure de données de l'étalonnage tout ages</returns>
        sResumeEtalonnagesAllAge IPersistanceResumeEtalonnageAllAge.Read()
        {
            sResumeEtalonnagesAllAge resaa = new sResumeEtalonnagesAllAge
            {
                LEtalonnageAllAges = new List<sResumeEtalonnageAllAge>()
            };
            try
            {
                var sheet = ConnectionEtalonnage.Connect();
                resaa.TotalNumber = sheet.Cell(1, "K").Value.ToString();
                for (int i = 0; i < 8; i++)
                {
                    sResumeEtalonnageAllAge lreaa = new sResumeEtalonnageAllAge
                    {
                        AgeRange = sheet.Cell(3 + i, "J").Value.ToString(),
                        NumberPersoneTest = int.Parse(sheet.Cell(3 + i, "K").Value.ToString()),
                        AverageAge = double.Parse(sheet.Cell(3 + i, "L").Value.ToString()),
                        SDAge = double.Parse(sheet.Cell(3 + i, "M").Value.ToString())
                    };
                    resaa.LEtalonnageAllAges.Add(lreaa);
                }
            }
            catch(Exception e)
            {
            }
            return resaa;
        }

        /// <summary>
        /// Récupères les données de l'étalonnage de l'age mentionné
        /// dans le fichier de données
        /// </summary>
        /// <param name="_age">Age de la personne passant le test</param>
        /// <returns>Structure de données de l'étalonnage de l'age mentionné</returns>
        sEtalonnages IPersistancesEtalonnages.Read(int _age)
        {
            int i = 0;
            sEtalonnages etalonnages = new sEtalonnages
            {
                LEtalonnages = new List<sEtalonnage>()
            };
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
                    sEtalonnage etalonnage = new sEtalonnage
                    {
                        NumberTrial = sheet.Cell(i + j, "B").Value.ToString(),
                        AverageMove = double.Parse(sheet.Cell(i + j, "C").Value.ToString()),
                        SDMove = double.Parse(sheet.Cell(i + j, "D").Value.ToString()),
                        AverageRepeat = double.Parse(sheet.Cell(i + j, "E").Value.ToString()),
                        SDRepeat = double.Parse(sheet.Cell(i + j, "F").Value.ToString()),
                        AverageScore = double.Parse(sheet.Cell(i + j, "G").Value.ToString()),
                        SDScore = double.Parse(sheet.Cell(i + j, "H").Value.ToString())
                    };
                    etalonnages.LEtalonnages.Add(etalonnage);
                }               
            }
            catch(Exception e)
            {              
            }
            return etalonnages;
        }

        /// <summary>
        /// Ecrit les données d'étalonnages récupéré dans 
        /// le fichier de résultat de l'utilisateur du test
        /// </summary>
        /// <param name="_sEtalonnages">Structure de données a sauvegarder</param>
        /// <param name="_nameSave">Nom pour la sauvegarde du fichier</param>
        /// <returns>Si la sauvegarde a réussi</returns>
        bool IPersistancesEtalonnages.Write(sEtalonnages _sEtalonnages, string _nameSave)
        {
            int i = 0;
            try
            {
                var sheet = ConnectionResult.Connect();
                sheet.Cell(28 + i, "A").Value = _sEtalonnages.Name;
                foreach (sEtalonnage etalonnage in _sEtalonnages.LEtalonnages)
                {
                    sheet.Cell(28 + i, "B").Value = etalonnage.NumberTrial;
                    sheet.Cell(28 + i, "C").Value = etalonnage.AverageMove;
                    sheet.Cell(28 + i, "D").Value = etalonnage.SDMove;
                    sheet.Cell(28 + i, "E").Value = etalonnage.AverageRepeat;
                    sheet.Cell(28 + i, "F").Value = etalonnage.SDRepeat;
                    sheet.Cell(28 + i, "G").Value = etalonnage.AverageScore;
                    sheet.Cell(28 + i, "H").Value = etalonnage.SDScore;
                    i++;
                }
                return ConnectionResult.Save(_nameSave);
            }
            catch(Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Resultat test score
        /// <summary>
        /// Ecrit : le nom du test, Moyenne de mouvement, Moyenne de répétition, Moyenne du score
        /// dans le fichier de données
        /// </summary>
        /// <param name="_score">Structure des données générale du test</param>
        /// <param name="_nameSave">Nom pour la sauvegarde du fichier</param>
        /// <returns>Si la sauvegarde a réussi</returns>
        bool IPersistanceTestScore.Write(sTestScore _score, string _nameSave)
        {
            try
            {
                var sheet = ConnectionResult.Connect();
                sheet.Cell("B10").Value = _score.TestName;
                sheet.Cell("B20").Value = _score.AverageMove;
                sheet.Cell("B21").Value = _score.AverageRepeat;
                sheet.Cell("B22").Value = _score.AverageScore;
                return ConnectionResult.Save(_nameSave);
            }
            catch(Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Ecrit : le resultat pour chaque manche du test
        /// </summary>
        /// <param name="_score">Structure de données de chaque manche du test</param>
        /// <param name="_nameSave">Nom pour la sauvegarde du fichier</param>
        /// <returns>Si la sauvegarde a réussi</returns>
        bool IPersistanceTrialsScore.Write(sTrialsScore _score, string _nameSave)
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
                return ConnectionResult.Save(_nameSave);
            }
            catch(Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Ecrit : les inforamtions de l'utilisateur
        /// </summary>
        /// <param name="_user">Structure contenant les inforamtions de l'utilisateur</param>
        /// <param name="_nameSave">Nom pour la sauvegarde du fichier</param>
        /// <returns>Si la sauvegarde a réussi</returns>
        bool IPersistanceUser.Write(sUser _user, string _nameSave)
        {
            try
            {
                var sheet = ConnectionResult.Connect();
                sheet.Cell("B3").Value = _user.LastName + " " + _user.FirstName;
                sheet.Cell("B4").Value = _user.Genre;
                sheet.Cell("B5").Value = _user.DateOfBirth.ToString("dd/MM/yyyy");
                sheet.Cell("B6").Value = _user.Age;
                sheet.Cell("B7").Value = _user.DateOfTheDay.ToString("dd/MM/yyyy");
                sheet.Cell("B8").Value = _user.DateOfTheDay.ToString("HH:mm:ss");       
                return ConnectionResult.Save(_nameSave);
            }
            catch(Exception e)
            {
                return false;
            }
        }
        #endregion
        #endregion
    }
}
