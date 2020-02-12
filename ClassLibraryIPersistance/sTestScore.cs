using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sTestScore
    {
        #region Propriétées
        /// <summary>
        /// <see cref="testname">Nom du test</see>
        /// <see cref="averageMove">Moyenne des mouvements du test</see>
        /// <see cref="averageRepeat">Moyenne des répétitions du test</see>
        /// <see cref="averageScore">Moyenne des scores du test</see>
        /// </summary>
        private string testname;
        private double averageMove;
        private double averageRepeat;
        private double averageScore;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string TestName { get => testname; set => testname = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        #endregion
    }
}
