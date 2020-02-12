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
        /// <summary>
        /// <see cref="totalNumber">Nombre total de personne testé tout ages confondu</see>
        /// <see cref="lEtalonnageAllAges">Liste des étalonnages tout ages confondu</see>
        /// </summary>
        private string totalNumber;
        private List<sResumeEtalonnageAllAge> lEtalonnageAllAges;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur des propriétées
        /// </summary>
        public string TotalNumber { get => totalNumber; set => totalNumber = value; }
        public List<sResumeEtalonnageAllAge> LEtalonnageAllAges { get => lEtalonnageAllAges; set => lEtalonnageAllAges = value; }
        #endregion
    }
}
