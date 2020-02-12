using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sEtalonnage
    {
        #region Propriétées
        /// <summary>
        /// <see cref="numberTrial">Numéro de manche de l'étalonnage</see>
        /// <see cref="averageMove">Moyenne de mouvement de l'étalonnage</see>
        /// <see cref="sDMove">Ecart type du nombre de mouvement de l'étalonnage</see>
        /// <see cref="averageRepeat">Moyenne de répétition de l'étalonnage</see>
        /// <see cref="sDRepeat">Ecart type du nombre de répétition de l'étalonnage</see>
        /// <see cref="averageScore">Moyenne des scores de l'étalonnage</see>
        /// <see cref="sDScore">Ecart type du score de l'étalonnage</see>
        /// </summary>
        private string numberTrial;
        private double averageMove;
        private double sDMove;
        private double averageRepeat;
        private double sDRepeat;
        private double averageScore;
        private double sDScore;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string NumberTrial { get => numberTrial; set => numberTrial = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double SDMove { get => sDMove; set => sDMove = value; }
        public double AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public double SDRepeat { get => sDRepeat; set => sDRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        public double SDScore { get => sDScore; set => sDScore = value; }
        #endregion
    }
}
