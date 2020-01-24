using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sTrialsScore
    {
        #region Propriétées
        private List<sTrialScore> ltrials;
        #endregion

        #region Accesseurs
        public List<sTrialScore> Ltrials { get => ltrials; set => ltrials = value; }
        #endregion
    }
}
