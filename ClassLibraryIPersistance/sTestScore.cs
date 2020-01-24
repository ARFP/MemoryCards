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
        private string testname;
        private double averageMove;
        private double averageRepeat;
        private double averageScore;
        #endregion

        #region Accesseurs
        public string TestName { get => testname; set => testname = value; }
        public double AverageMove { get => averageMove; set => averageMove = value; }
        public double AverageRepeat { get => averageRepeat; set => averageRepeat = value; }
        public double AverageScore { get => averageScore; set => averageScore = value; }
        #endregion
    }
}
