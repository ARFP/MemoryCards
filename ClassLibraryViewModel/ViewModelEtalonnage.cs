using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryViewModel
{
    /// <summary>
    /// L'étalonnage sont les données de références qui serve a
    /// être comparé avec celle de l'utilisateur
    /// </summary>
    public class ViewModelEtalonnage : ObservableObject
    {
        #region Propriétées
        private Etalonnage etalonnage;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Chaque accesseur font référence a une propriété de l'etalonnage
        /// Leur état est survéillé par NotifyPropertyChanged
        /// <see cref="NumberTrial">Numéro d'une manche</see>
        /// <see cref="AverageMove">Moyenne des mouvements d'une manche</<see>
        /// <see cref="SDMove">Ecart type des mouvements d'une manche</see>
        /// <see cref="AverageRepeat">Moyennes des répétitions d'une manche</see>
        /// <see cref="SDRepeat">Ecart type des répétions d'une manche</see>
        /// <see cref="AverageScore">Moyennes des scores d'une manches</see>
        /// <see cref="SDScore">Ecart type des scores d'une manche</see>
        /// </summary>
        public string NumberTrial { get { return etalonnage.NumberTrial; } set { etalonnage.NumberTrial = value; OnPropertyChanged(nameof(NumberTrial)); } }
        public double AverageMove { get { return etalonnage.AverageMove; } set { etalonnage.AverageMove = value; OnPropertyChanged(nameof(AverageMove)); } }
        public double SDMove { get { return etalonnage.SDMove; } set { etalonnage.SDMove = value; OnPropertyChanged(nameof(SDMove)); } }
        public double AverageRepeat { get { return etalonnage.AverageRepeat; } set { etalonnage.AverageRepeat = value; OnPropertyChanged(nameof(AverageRepeat)); } }
        public double SDRepeat { get { return etalonnage.SDRepeat; } set { etalonnage.SDRepeat = value; OnPropertyChanged(nameof(SDRepeat)); } }
        public double AverageScore { get { return etalonnage.AverageScore; } set { etalonnage.AverageScore = value; OnPropertyChanged(nameof(AverageScore)); } }
        public double SDScore { get { return etalonnage.SDScore; } set { etalonnage.SDScore = value; OnPropertyChanged(nameof(SDScore)); } }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="_etalonnage"></param>
        public ViewModelEtalonnage(Etalonnage _etalonnage)
        {
            etalonnage = _etalonnage;
        }
        #endregion
    }
}
