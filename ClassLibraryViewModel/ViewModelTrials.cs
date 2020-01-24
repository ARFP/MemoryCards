using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    public class ViewModelTrials : ObservableObject
    {
        #region Propriétées
        private Trials trials;
        private List<ViewModelTrial> lVMTrial;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Chaque accesseur font référence a une propriété de la Carte
        /// Leur état est survéillé par NotifyPropertyChanged
        /// </summary>
        public List<ViewModelTrial> LVMTrial { get { return lVMTrial; } set { lVMTrial = value; OnPropertyChanged(nameof(LVMTrial)); } }
        #endregion

        #region Constructeur
        public ViewModelTrials(Trials _trials)
        {
            trials = _trials;
            lVMTrial = new List<ViewModelTrial>();
            foreach (Trial t in _trials.LTrial)
            {
                lVMTrial.Add(new ViewModelTrial(t));
            }
        }
        #endregion

        #region Méthodes
        public bool Save(string _pathSave)
        {
            return trials.Save(_pathSave);
        }
        #endregion
    }
}
