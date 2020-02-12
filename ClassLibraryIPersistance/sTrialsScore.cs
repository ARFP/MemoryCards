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
        /// <summary>
        /// <see cref="ltrials">Liste des manches du test</see>
        /// </summary>
        private List<sTrialScore> ltrials;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public List<sTrialScore> Ltrials { get => ltrials; set => ltrials = value; }
        #endregion
    }
}
