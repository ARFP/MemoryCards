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
        private string ageRange;
        private int numberPersoneTest;
        private double averageAge;
        private double sDAge;
        #endregion

        #region Accesseurs
        public string AgeRange { get => ageRange; set => ageRange = value; }
        public int NumberPersoneTest { get => numberPersoneTest; set => numberPersoneTest = value; }
        public double AverageAge { get => averageAge; set => averageAge = value; }
        public double SDAge { get => sDAge; set => sDAge = value; }
        #endregion
    }
}
