using ClassLibraryIPersistance;
using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMemento
{
    public class Trials
    {
        #region Propriétées
        /// <summary>
        /// Liste de trials
        /// </summary>
        private List<Trial> lTrials;
        /// <summary>
        /// Pour la persistance du score du trial
        /// </summary>
        private IPersistanceTrialsScore iPersistance;
        #endregion

        #region Accesseur
        public List<Trial> LTrial { get => lTrials; set => lTrials = value; }
        #endregion

        #region Constructeur
        public Trials()
        {
            lTrials = new List<Trial>();
            iPersistance = new Persistance();
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Permet de transformer un Trials en sTrialsScore
        /// </summary>
        /// <param name="_trials"></param>
        public static implicit operator sTrialsScore(Trials _trials)
        {
            sTrialsScore ts = new sTrialsScore();
            ts.Ltrials = new List<sTrialScore>();
            foreach(Trial t in _trials.LTrial)
            {
                ts.Ltrials.Add(t);
            }
            return ts;
        }
        /// <summary>
        /// Sauvegarde tous les trials
        /// </summary>
        /// <param name="_pathSave">Le chemin pour la sauvegarde</param>
        /// <returns>Valide ou non la sauvegarde</returns>
        public bool Save(string _pathSave)
        {
            return iPersistance.Write(this, _pathSave);
        }
        #endregion
    }
}
