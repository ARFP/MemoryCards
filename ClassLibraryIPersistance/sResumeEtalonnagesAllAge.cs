using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIPersistance
{
    public struct sResumeEtalonnagesAllAge
    {
        #region Propriétées
        private string totalNumber;
        private List<sResumeEtalonnageAllAge> lEtalonnageAllAges;
        #endregion

        #region Accesseurs
        public string TotalNumber { get => totalNumber; set => totalNumber = value; }
        public List<sResumeEtalonnageAllAge> LEtalonnageAllAges { get => lEtalonnageAllAges; set => lEtalonnageAllAges = value; }
        #endregion
    }
}
