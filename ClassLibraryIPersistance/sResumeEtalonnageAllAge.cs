using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sResumeEtalonnageAllAge
    {
        #region Propriétées
        /// <summary>
        /// <see cref="ageRange">Tranche d'age</see>
        /// <see cref="numberPersoneTest">Nombre de personne testée de la tranche d'age</see>
        /// <see cref="averageAge">Moyenne de la tranche d'age</see>
        /// <see cref="sDAge">Ecart type de de la tranche d'age</see>
        /// </summary>
        private string ageRange;
        private int numberPersoneTest;
        private double averageAge;
        private double sDAge;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string AgeRange { get => ageRange; set => ageRange = value; }
        public int NumberPersoneTest { get => numberPersoneTest; set => numberPersoneTest = value; }
        public double AverageAge { get => averageAge; set => averageAge = value; }
        public double SDAge { get => sDAge; set => sDAge = value; }
        #endregion
    }
}
